/*-------------------------------------------------------------------------
					Technika Mikroprocesorowa 2 - PROJEKT
					REFLEKSOMIERZ
					autor: Michal Wozniak 
					19.12.2021r.
----------------------------------------------------------------------------*/
	
// BIBLIOTEKI	
#include "MKL05Z4.h"
#include "frdm_bsp.h"
#include "lcd1602.h"
#include "klaw.h"
#include "TPM.h"
#include <stdio.h>
#include <string.h>
#include <stdlib.h>

// DEFINICJE MAKR
#define DIV_CORE	16
#define LED_B         (1<<10)
#define LED_B_MASK		(1<<10)
#define LED_G         (1<<9)
#define LED_G_MASK		(1<<9)

// ZMIENNE
int czas=0, random=0, random_new=0, zmienna_P1, zmienna_P2;			    // CZAS / LOSOWANA LICZBA OPÓZNIENIA / ZMIENNE DO NAJLEPSZYCH CZASÓW	
int P1_czas_reakcji=10000, P2_czas_reakcji=10000;                   // CZASY REAKCJI P1 / P2
int P1W1_czas = 0, P1W2_czas = 0, P2W1_czas = 0, P2W2_czas = 0;     // TOP 2 CZASY GRACZA P1 I P2
int zwyciestwa_P1=0, zwyciestwa_P2=0, koniec = 1;                   // LICZBA ZWYCIESTW GRACZY
uint8_t msekunda=0;		                                            	// LICZNIK  (tylko 0 albo 1)
uint8_t mmsekunda_OK=0;		                                          // PRZEKAZUJE KOLEJNE WIELOKROTNOSCI 1 ms
uint8_t S1_press=0;
uint8_t S2_press=0;	
uint8_t S3_press=0;
uint8_t S4_press=0;

// ZMIENNE MUZYKA
uint16_t mod_curr=40082;
uint16_t ampl;
uint16_t Tony[]={40082, 37826, 35701, 33702, 31813, 30027, 28339, 26748, 25249, 23830, 22493, 21229, 20041};  
uint8_t	CHAMPIONS_ton[]={6,5,6,5,3,1,4,1,2,3,3,6,7,8,10,8,4,5,3,1,2};
uint8_t	CHAMPIONS_czas[]={9,3,3,4,5,3,4,6,5,5,2,5,2,2,4,5,2,2,10,7,7};
uint8_t CHAMPIONS_przerwa[]={4,2,2,2,2,2,2,3,2,5,2,5,2,2,2,2,2,2,10,2,2};
uint8_t	ton=0;   // numer elementu w tablicach
uint8_t sekunda=0;			
uint8_t	gap_ton=0;
uint8_t on_off=255;
uint8_t czas_glosnik=1;


void SysTick_Handler(void)	// Podprogram obslugi przerwania od SysTick'a
{    
	 // 1 funkcja licznika SysTick - liczenie opóznienia klikniecia guzika
		if (koniec == 1){
				msekunda+=1;				// Licz interwaly rowne 1ms
			if(msekunda==1)
			{
				msekunda=0;
				mmsekunda_OK=1;		// Daj znac, ze minela 1ms
			}
	}
		
	 // 2 funkcja licznika SysTick - obslugiwanie glosnika
	if (koniec == 0){
				sekunda+=1;
		if(sekunda==czas_glosnik)
		{
			switch(gap_ton)
			{
				case 0	:		czas_glosnik = CHAMPIONS_czas[ton];	      // czas nuty
										mod_curr = Tony[CHAMPIONS_ton[ton]]/4;			
										TPM0->MOD = mod_curr;   // modulo wypelnienie przebiegu, czestotliwosc
										ampl = (int)mod_curr/50;
										TPM0->CONTROLS[3].CnV = ampl;
										TPM0->SC |= TPM_SC_CMOD(1);   // wlaczenie licznika
										sekunda = 0;
										gap_ton = 1;
										PTB->PTOR |= LED_B;
										PTB->PTOR |= LED_G;
										break;
				case 1	:		TPM0->SC &= ~(TPM_SC_CMOD(3));
										TPM0->CNT = 0;
										sekunda = 0;
										czas_glosnik = CHAMPIONS_przerwa[ton];		
										ton += 1;
										if(ton == 21)			
											ton = 0;
										gap_ton = 0;
										break;
			}
		}
	}
}

void PORTA_IRQHandler(void)	// Podprogram obslugi przerwania od klawiszy S1, S2, S3 i S4
{
	uint32_t buf;
	buf = PORTA->ISFR & (S1_MASK | S2_MASK | S3_MASK | S4_MASK);

	switch(buf)
	{
		case S1_MASK:	DELAY(10)
									if(!(PTA->PDIR&S1_MASK))		// Minimalizacja drgan zestyków
									{
										if(!(PTA->PDIR&S1_MASK))	// Minimalizacja drgan zestyków (c.d.)
										{
											if(!S1_press)
											{
												S1_press=1;
											}
										}
									}
									break;
		case S2_MASK:	DELAY(10)
									if(!(PTA->PDIR&S2_MASK))		// Minimalizacja drgan zestyków
									{
										if(!(PTA->PDIR&S2_MASK))	// Minimalizacja drgan zestyków (c.d.)
										{
											if(!S2_press)
											{
												S2_press=1;
											}
										}
									}
									break;
		case S3_MASK:	DELAY(10)
									if(!(PTA->PDIR&S3_MASK))		// Minimalizacja drgan zestyków
									{
										if(!(PTA->PDIR&S3_MASK))	// Minimalizacja drgan zestyków (c.d.)
										{
											if(!S3_press)
											{
												S3_press=1;
											}
										}
									}
									break;
		case S4_MASK:	DELAY(10)
									if(!(PTA->PDIR&S4_MASK))		// Minimalizacja drgan zestyków
									{
										if(!(PTA->PDIR&S4_MASK))	// Minimalizacja drgan zestyków (c.d.)
										{
											if(!S4_press)
											{
												S4_press=1;
											}
										}
									}
									break;
		default:			break;
	}	
	PORTA->ISFR |=  S1_MASK | S2_MASK | S3_MASK | S4_MASK;	// Kasowanie wszystkich bitów ISFR
	NVIC_ClearPendingIRQ(PORTA_IRQn);
}

int main (void) 
{
	char display[]={0x20,0x20,0x20,0x20,0x20,0x20,0x20,0x20,0x20,0x20,0x20,0x20,0x20,0x20,0x20,0x20};
	
	// Ustawienie bitów odpowiedzialnych za diody B i G
	PTB->PDDR |= LED_B_MASK;   // Rola - wyjscie 
	PTB->PDDR |= LED_G_MASK;   // Rola - wyjscie 
	PTB->PTOR |= LED_G;        // Zmiana stanu na przeciwny
	PTB->PTOR |= LED_B;        // Zmiana stanu na przeciwny
	
	Klaw_Init();     // Inicjalizacja klawiatury
	Klaw_S2_4_Int();
	LCD1602_Init();		 // Inicjalizacja LCD
	LCD1602_ClearAll();					// Wyczysc ekran
	LCD1602_Print("REFLEKSOMIERZ");		// Wyswietl powitanie 
	DELAY(2000);
	LCD1602_ClearAll();
	
			LCD1602_Print("Zasady:");
			DELAY(500);
			LCD1602_ClearAll();	
			LCD1602_Print("Gracz P1 -> S2");
			LCD1602_SetCursor(0,1);	
			LCD1602_Print("Gracz P2 -> S4");
			DELAY(1500);
			LCD1602_ClearAll();	
			LCD1602_Print("Aby zakonczyc gr");
			DELAY(400);
			LCD1602_ClearAll();
			LCD1602_Print("zakonczyc gre, p");
			DELAY(400);
			LCD1602_ClearAll();
			LCD1602_Print("gre, po probie, ");
			DELAY(400);
			LCD1602_ClearAll();
			LCD1602_Print("po probie, nacis");
			DELAY(400);
			LCD1602_ClearAll();
			LCD1602_Print("probie, nacisnij");
			DELAY(400);
			LCD1602_ClearAll();
			LCD1602_Print("nacisnij dwa raz");
			DELAY(400);
			LCD1602_ClearAll();
			LCD1602_Print("dwa razy S3");
			DELAY(1000);
			
	LCD1602_ClearAll();				      
	LCD1602_Print("Press S2 TOBEGIN");	
	PWM_Init();				// Inicjalizacja licznika TPM0 (PWM „Low-true pulses”) - do dzwieków
	SysTick_Config(SystemCoreClock/1000 ); // 1ms
	
	// Liczy czas od uruchomienia programu do przejscia dalej
	do{
			if(mmsekunda_OK)
				{	
					random+= 1;           // przechowuje czas od uruchomienia programu do przejscia dalej guzikiem S2           
					mmsekunda_OK = 0;
				}
	}while(!S2_press);   
	
	
	// GLOWNA PETLA GRY
	while(koniec){
			SysTick_Config(1);   // Zatrzymuje licznik
			S2_press=0;
			S4_press=0;
			S3_press=0;
			LCD1602_ClearAll();					
	
		
			// wycisza glosnik przy kolejnych próbach gry
			TPM0->SC &= ~(TPM_SC_CMOD(3));
			TPM0->CNT=0;

			LCD1602_ClearAll();	
			LCD1602_Print("Kto pierwszy");
			LCD1602_SetCursor(0,1);	
			LCD1602_Print("ten lepszy !");
			DELAY(500);
			LCD1602_ClearAll();	
			LCD1602_Print(" Powodzenia !!!");
			DELAY(500);
			LCD1602_ClearAll();
			LCD1602_Print(" Przygotuj sie!");	// Wyswietl stan poczatkowy liczby wcisniec klawisza S3
		  DELAY(600);
		  LCD1602_ClearAll();
			
			random = (random % 10);     // jedna ostatnia cyfra z liczby 'pseudolosowej' mówi ile sekund program ma czekac ma na start 1 gry
			
			// opóznienie dla kolejnych gier, dla 1 gry nie uruchomi sie
			if (random_new != 0){
				random = (random_new % 10);
			}
			
			// Wyswietlenie czasu opoznienia
			//LCD1602_SetCursor(0,1);
			//sprintf(display,"%02d",random);
			//LCD1602_Print(display);
			//DELAY(500);
			
			S2_press=0;
			LCD1602_ClearAll();
			
			// opóznienie o wylosowana liczbe sekund
			for (int t = 0; t<random; t++){
				DELAY(1000);
			}
			
			SysTick_Config(SystemCoreClock/1000 ); //1ms
			czas=0;    // Startuje licznik
			LCD1602_Print("-----Start!-----");
			LCD1602_SetCursor(0,1);
			LCD1602_Print("################");
			
			// Uruchomienia pikania po starcie
			mod_curr = 5960;	// wybrany dzwiek sygnalizujacy start
			TPM0->MOD = mod_curr;
			ampl=(int)mod_curr/50;
			TPM0->CONTROLS[3].CnV = ampl;	
			TPM0->SC |= TPM_SC_CMOD(1);			
			
			do{
				if(mmsekunda_OK)
					{	
					czas += 1;       // licznik liczy czas reakcji graczy		 
					random_new += 1;    // tu defioniowane bedzie opoznienie startu drugiej i kolejnych gier
					mmsekunda_OK = 0;
					}
					
				else if(S2_press)						
				{
					SysTick_Config(1);
					
					if(czas<=1)    // FALLSTART P1
						{
						LCD1602_ClearAll();
						LCD1602_Print("FALL START P1!");
						DELAY(2000);
						S2_press=0;
						S4_press=0;
						TPM0->SC &= ~(TPM_SC_CMOD(3));
						TPM0->CNT=0;	  // Wycisza glosnik
						break;
						}
					else
						{
						P1_czas_reakcji=czas;
						if(P1_czas_reakcji<P2_czas_reakcji){   
							zwyciestwa_P1 = zwyciestwa_P1 + 1;    // Zwieksza o 1 liczbe zwyciestw
							LCD1602_ClearAll();
							LCD1602_Print("P1 wygral!  S3");
							LCD1602_SetCursor(0,1);
							
							
							// SYSTEM ZAPISYWANIA NAJLEPSZYCH WYNIKOW P1
							if((P1W1_czas != 0) && (P1W2_czas == 0)){       // Sprawdza czy sloty sa puste
								P1W2_czas = czas;
							}
							if(P1W1_czas == 0){                             // Sprawdza czy sloty sa puste
								P1W1_czas = czas;
							}
							if((P1W1_czas != 0) && (P1W2_czas != 0)){     
								if(P1W1_czas < P1W2_czas){                   // Porównuje oba sloty, zapisuje szybszy wynik
									if (czas < P1W1_czas){
										P1W2_czas = P1W1_czas;
										P1W1_czas = czas;
									}
								}
								if(P1W1_czas > P1W2_czas){
									zmienna_P1 = P1W2_czas;
									P1W2_czas = P1W1_czas;
									P1W2_czas = zmienna_P1;
									if (czas < P1W1_czas){
										P1W2_czas = P1W1_czas;
										P1W1_czas = czas;
									}									
								}
							}
					
							sprintf(display,"%02d",P1_czas_reakcji);  //wyswietlanie czasu reakcji od Start
							LCD1602_Print(display);
							LCD1602_Print(" ms    RESET");
							P1_czas_reakcji=10000;
							TPM0->SC &= ~(TPM_SC_CMOD(3));
							TPM0->CNT=0;	  // Wycisza glosnik
						}
						DELAY(2000);  // Odczekanie az gracze puszcza guziki i zeruje nacisniecie
						S2_press=0;
						S4_press=0;						
						}
				}
				
				else if(S4_press)							
				{
					SysTick_Config(1);
					
					
					if(czas<=1)    // FALLSTART P2
						{
						LCD1602_ClearAll();
						LCD1602_Print("FALL START P2!");
						DELAY(2000);
						S4_press=0;
						S2_press=0;
						TPM0->SC &= ~(TPM_SC_CMOD(3));
						TPM0->CNT=0;		  // Wycisza glosnik
						break;
						}
					else
						{
						P2_czas_reakcji=czas;
						if(P2_czas_reakcji<P1_czas_reakcji){
							zwyciestwa_P2 = zwyciestwa_P2 + 1;
							LCD1602_ClearAll();
							LCD1602_Print("P2 wygral!  S3");
							LCD1602_SetCursor(0,1);
								
							
							// SYSTEM ZAPISYWANIA NAJLEPSZYCH WYNIKOW P2
							if((P2W1_czas != 0) && (P2W2_czas == 0)){        // Sprawdza czy sloty sa puste
								P2W2_czas = czas;
							}
							if(P2W1_czas == 0){                              // Sprawdza czy sloty sa puste
								P2W1_czas = czas;
							}
							
							if((P2W1_czas != 0) && (P2W2_czas != 0)){
								if(P2W1_czas < P2W2_czas){                   // Porównuje oba sloty, zapisuje szybszy wynik
									if (czas < P2W1_czas){
										P2W2_czas = P2W1_czas;
										P2W1_czas = czas;
									}
								}
								if(P2W1_czas > P2W2_czas){
									zmienna_P2 = P2W2_czas;
									P2W2_czas = P2W1_czas;
									P2W2_czas = zmienna_P2;
									if (czas < P2W1_czas){
										P2W2_czas = P2W1_czas;
										P2W1_czas = czas;
									}									
								}
							}
							
							sprintf(display,"%02d",P2_czas_reakcji);
							LCD1602_Print(display);
							LCD1602_Print(" ms    RESET");
							P2_czas_reakcji=10000;		
							TPM0->SC &= ~(TPM_SC_CMOD(3));
							TPM0->CNT=0;		  // Wycisza glosnik					
						}
						DELAY(2000);  // Odczekanie az gracze puszcza guziki i zeruje nacisniecie
						S4_press=0;
						S2_press=0;						
						}
				}
				
				if (czas == 5000){
					LCD1602_ClearAll();
					LCD1602_Print("   ROB COS !!!");
					DELAY(1000);
					TPM0->SC &= ~(TPM_SC_CMOD(3));
					TPM0->CNT=0;
					S3_press = 1;
				}
				
			
			}while(!S3_press);                      // jedno nacisniecie S3 resetuje i gra sie od nowa
			
			S3_press=0;
			LCD1602_ClearAll();
			DELAY(800);
			
			if(S3_press){                           // przytrzymanie S3 gdy zniknie napis - konczy gre
				koniec = 0;
			}
	}     
	
		// Wyswietlenie punktacji
		S3_press = 0;
		LCD1602_ClearAll();
		LCD1602_Print("   KONIEC GRY");
		DELAY(2000);
		LCD1602_ClearAll();
		LCD1602_Print("P1 punkty: ");
		sprintf(display,"%02d",zwyciestwa_P1);
		LCD1602_Print(display);
	
		LCD1602_SetCursor(0,1);	
		LCD1602_Print("P2 punkty: ");
		sprintf(display,"%02d",zwyciestwa_P2);
		LCD1602_Print(display);

	
	// Zainicjowanie licznika SysTick do grania muzyki
	koniec = 0;
	SysTick_Config(SystemCoreClock/DIV_CORE );	// Start licznika SysTick
	ampl=(int)mod_curr/50;
	PTB->PTOR |= LED_B;
	
  while(1){
		
		// Mechanizm zatrzymujacy muzyke
		if(S4_press)							
		{
			on_off=(~on_off);
			if(on_off)
				SysTick_Config(SystemCoreClock/DIV_CORE);
			else
			{
				SysTick_Config(1);
				TPM0->SC &= ~(TPM_SC_CMOD(3));
				TPM0->CNT=0;
			}
			S4_press=0;
		}
		
		
		// Wyswietlenie najleszych wyników
		DELAY(4000);
		LCD1602_ClearAll();
		LCD1602_Print("TOP 2 CZASY");
		LCD1602_SetCursor(0,1);	
		LCD1602_Print("GRACZA P1 / P2");
		DELAY(2000);
		
		
		LCD1602_ClearAll();
		LCD1602_Print("P1:");
		sprintf(display,"%02d",P1W1_czas);
		LCD1602_Print(display);
		LCD1602_Print("ms | ");
		sprintf(display,"%02d",P1W2_czas);
		LCD1602_Print(display);
		LCD1602_Print("ms");
	
		LCD1602_SetCursor(0,1);	
		LCD1602_Print("P2:");
		sprintf(display,"%02d",P2W1_czas);
		LCD1602_Print(display);
		LCD1602_Print("ms | ");
		sprintf(display,"%02d",P2W2_czas);
		LCD1602_Print(display);
		LCD1602_Print("ms");
	}
}
