#include <stdlib.h>
#include <iostream>
#include <windows.h>      // Funkcja Sleep()
#include <conio.h>        // U¿yte funkcje   _kbhit() _getch()


using namespace std;

// Zmienne globalne
bool Koniec_Gry;
int x, y, robak_X, robak_Y, mucha_X, mucha_Y;                     // Koordynaty
int wynik, szerokosc, wysokosc, ogon_dlugosc;                     // Zmienne reprezentuj¹ce dynamiczne parametry gry
char menu, poziom, predkosc, mapa;                                // Zmienne definiuj¹ce rozgrywke 
char skora, waz, dalej, kierunek, wyjscie;                        // Zmienne definiuj¹ce rozgrywke 
int ogon_X[70], ogon_Y[70];                                       // Tablica typu int - przechowuje wspó³rzêdne budowy wê¿a, MAX 70
string poziom_napis = "", predkosc_napis = "", mapa_napis = "", skora_napis = "";    // Zmienne string do podsumowania

// Klasa reprezentuj¹ca rodzaj wê¿a w trybie automatycznym
class Rozgrywka {
private:
	char m_poziom, m_predkosc, m_mapa, m_skora;
public:
	Rozgrywka(char poziom = '0', char predkosc = '0', char mapa = '0', char skora = '0') :
		m_poziom{ poziom }, m_predkosc{ predkosc }, m_mapa{ mapa }, m_skora{ skora }
	{}

	char get_poziom(void) const { return m_poziom; }
	char get_predkosc(void) const { return m_predkosc; }
	char get_mapa(void) const { return m_mapa; }
	char get_skora(void) const { return m_skora; }
	void set_poziom(char poziom) { m_poziom = poziom; }
	void set_predkosc(char predkosc) { m_predkosc = predkosc; }
	void set_mapa(char mapa) { m_mapa = mapa; }
	void set_skora(char skora) { m_skora = skora; }
};

void menu_wypisz() {
	cout << "            MENU" << endl << endl;
	Sleep(300);

	cout << "       Wpisz liczbe:" << endl;
	Sleep(100);
	cout << "       GRA MANUALNA     -> 1" << endl;
	Sleep(100);
	cout << "       GRA AUTOMATYCZNA -> 2" << endl;
	Sleep(100);
	cout << "       SAMOUCZEK        -> 3" << endl;
	Sleep(100);
	cout << "       WYJSCIE Z GRY    -> 4" << endl;

	int error = 1;
	while (error) {
		cin >> menu;

		if (!isalpha(menu)) {
			if (menu == '1' || menu == '2' || menu == '3' || menu == '4') {
				error = 0;
			}
			else {
				cout << endl << "ZLY ZAKRES ! " << endl << endl;
			}
		}
		else {
			cout << endl << "ZLY ZAKRES ! " << endl << endl;
		}
	}

	system("cls");
}

void ikona_wypisz() {
	cout << "           /^\\ /^\\         " << endl;
	cout << "         _|___| O |        " << endl;
	cout << " \\/     /~     \\_/ \\       " << endl;
	cout << "  \\____|__________/  \\   " << endl;
	cout << "         \\_______      \\   " << endl;
	cout << "                 `\\     \\                  Y             " << endl;
	cout << "                  |      |                  |           " << endl;
	cout << "                 /      /                    |         " << endl;
	cout << "                /     /                       |\\_       " << endl;
	cout << "              /      /                         | \\_     " << endl;
	cout << "             /     /                            |  \\_   " << endl;
	cout << "           /     /             _----_            |   | " << endl;
	cout << "          /     /           _/-     ~~- _        |    | " << endl;
	cout << "         (      (         _-~    _--_    ~-_     /    /  " << endl;
	cout << "          C      ~-____-~/    _-~    ~-_    ~-_-/    /  " << endl;
	cout << "            ~-_           _-~          ~-_       _-~   " << endl;
	cout << "               ~--______-~                ~-___-~      " << endl;
}

void poziom_trudnosci_wypisz() {
	cout << "      *Wybierz poziom trudnosci*" << endl << endl;
	Sleep(300);
	system("cls");
	cout << "     **Wybierz poziom trudnosci**" << endl << endl;
	Sleep(300);
	system("cls");
	cout << "    ***Wybierz poziom trudnosci***" << endl << endl;
	Sleep(300);
	system("cls");
	cout << "   ****Wybierz poziom trudnosci****" << endl << endl;
	Sleep(700);
	cout << "       Wpisz liczbe:" << endl;
	Sleep(100);
	cout << "       LATWY  -> 1" << endl;
	Sleep(100);
	cout << "       TRUDNY -> 2" << endl;
	cout << endl << endl << "  Nacisnij '5' aby wrocic do MENU " << endl;

	int error = 1;
	while (error) {
		cin >> poziom;

		if (!isalpha(poziom)) {
			if (poziom == '1' || poziom == '2' || poziom == '5') {
				error = 0;
			}
			else {
				cout << endl << "ZLY ZAKRES ! " << endl << endl;
			}
		}
		else {
			cout << endl << "ZLY ZAKRES ! " << endl << endl;
		}
		if (poziom == '5') {    // mechanizm cofaj¹cy do MENU
			poziom = '0';
			wyjscie = '5';
			return;
		}
	}
	system("cls");
}

void szybkosc_wypisz() {
	if (wyjscie == '5') {
		return;
	}
	cout << "      *Wybierz predkosc gry*" << endl << endl;
	Sleep(300);
	system("cls");
	cout << "     **Wybierz predkosc gry***" << endl << endl;
	Sleep(300);
	system("cls");
	cout << "    ***Wybierz predkosc gry****" << endl << endl;
	Sleep(300);
	system("cls");
	cout << "   ****Wybierz predkosc gry*****" << endl << endl;
	Sleep(700);
	cout << "       Wpisz liczbe:" << endl;
	Sleep(100);
	cout << "       WOLNO   -> 1" << endl;
	Sleep(100);
	cout << "       SREDNIO -> 2" << endl;
	Sleep(100);
	cout << "       SZYBKO  -> 3" << endl;
	cout << endl << endl << "  Nacisnij '5' aby wrocic do MENU " << endl;

	int error = 1;
	while (error) {
		cin >> predkosc;

		if (!isalpha(predkosc)) {
			if (predkosc == '1' || predkosc == '2' || predkosc == '3' || predkosc == '5') {
				error = 0;
			}
			else {
				cout << endl << "ZLY ZAKRES ! " << endl << endl;
			}
		}
		else {
			cout << endl << "ZLY ZAKRES ! " << endl << endl;
		}
		if (predkosc == '5') {
			predkosc = '0';
			wyjscie = '5';
			return;
		}
	}
	system("cls");
}

void mapa_wypisz() {
	if (wyjscie == '5') {
		return;
	}
	cout << "      *Wybierz wielkosc mapy*" << endl << endl;
	Sleep(300);
	system("cls");
	cout << "     **Wybierz wielkosc mapy***" << endl << endl;
	Sleep(300);
	system("cls");
	cout << "    ***Wybierz wielkosc mapy****" << endl << endl;
	Sleep(300);
	system("cls");
	cout << "   ****Wybierz wielkosc mapy*****" << endl << endl;
	Sleep(700);
	cout << "       Wpisz liczbe:" << endl;
	Sleep(100);
	cout << "       MALA    -> 1" << endl;
	Sleep(100);
	cout << "       SREDNIA -> 2" << endl;
	Sleep(100);
	cout << "       DUZA    -> 3" << endl;
	cout << endl << endl << "  Nacisnij '5' aby wrocic do MENU " << endl;

	int error = 1;
	while (error) {
		cin >> mapa;

		if (!isalpha(mapa)) {
			if (mapa == '1' || mapa == '2' || mapa == '3' || mapa == '5') {
				error = 0;
			}
			else {
				cout << endl << "ZLY ZAKRES ! " << endl << endl;
			}
		}
		else {
			cout << endl << "ZLY ZAKRES ! " << endl << endl;
		}
		if (mapa == '5') {    // mechanizm cofaj¹cy do MENU
			mapa = '0';
			wyjscie = '5';
			return;
		}
	}

	system("cls");
}

void waz_wypisz() {
	if (wyjscie == '5') {
		return;
	}
	cout << "      *Wybierz swojego weza*" << endl << endl;
	Sleep(300);
	system("cls");
	cout << "     **Wybierz swojego weza***" << endl << endl;
	Sleep(300);
	system("cls");
	cout << "    ***Wybierz swojego weza****" << endl << endl;
	Sleep(300);
	system("cls");
	cout << "   ****Wybierz swojego weza*****" << endl << endl;
	Sleep(700);
	cout << "    Wpisz liczbe:" << endl << endl;
	Sleep(100);
	cout << "    Pyton Tygrysi   Numer 1   ->   Xxxxxxxx" << endl << endl;
	Sleep(100);
	cout << "    Boa Dusiciel    Numer 2   ->   Oooooooo" << endl << endl;
	Sleep(100);
	cout << "    Kobra           Numer 3   ->   Q*******" << endl;
	cout << endl << endl << "  Nacisnij '5' aby wrocic do MENU " << endl;

	int error = 1;
	while (error) {
		cin >> waz;

		if (!isalpha(waz)) {
			if (waz == '1' || waz == '2' || waz == '3' || waz == '5') {
				error = 0;
			}
			else {
				cout << endl << "ZLY ZAKRES ! " << endl << endl;
			}
		}
		else {
			cout << endl << "ZLY ZAKRES ! " << endl << endl;
		}
		if (waz == '5') {    // mechanizm cofaj¹cy do MENU
			waz = '0';
			wyjscie = '5';
			return;
		}
	}

	system("cls");
}

void skora_wypisz() {
	if (wyjscie == '5') {
		return;
	}
	cout << "      *Wybierz swojego weza*" << endl << endl;
	Sleep(300);
	system("cls");
	cout << "     **Wybierz swojego weza***" << endl << endl;
	Sleep(300);
	system("cls");
	cout << "    ***Wybierz swojego weza****" << endl << endl;
	Sleep(300);
	system("cls");
	cout << "   ****Wybierz swojego weza*****" << endl << endl;
	Sleep(700);
	cout << "    Wpisz liczbe:" << endl << endl;
	Sleep(100);
	cout << "    Pyton Tygrysi   Numer 1   ->   Xxxxxxxx" << endl << endl;
	Sleep(100);
	cout << "    Boa Dusiciel    Numer 2   ->   Oooooooo" << endl << endl;
	Sleep(100);
	cout << "    Kobra           Numer 3   ->   Q*******" << endl;
	cout << endl << endl << "  Nacisnij '5' aby wrocic do MENU " << endl;

	int error = 1;
	while (error) {
		cin >> skora;

		if (!isalpha(mapa)) {
			if (skora == '1' || skora == '2' || skora == '3' || skora == '5') {
				error = 0;
			}
			else {
				cout << endl << "ZLY ZAKRES ! " << endl << endl;
			}
		}
		else {
			cout << endl << "ZLY ZAKRES ! " << endl << endl;
		}
		if (skora == '5') {    // mechanizm cofaj¹cy do MENU
			skora = '0';
			wyjscie = '5';
			return;
		}
	}

	system("cls");
}

void podsumowanie_wypisz() {
	if (wyjscie == '5') {
		return;
	}
	cout << endl;

	if (poziom == '1') {
		poziom_napis = "LATWY";
	}
	if (poziom == '2') {
		poziom_napis = "MEDIUM";
	}
	if (poziom == '3') {
		poziom_napis = "TRUDNY";
	}
	if (predkosc == '1') {
		predkosc_napis = "WOLNA";
	}
	if (predkosc == '2') {
		predkosc_napis = "SREDNIA";
	}
	if (predkosc == '3') {
		predkosc_napis = "SZYBKA";
	}
	if (mapa == '1') {
		mapa_napis = "MALA";
	}
	if (mapa == '2') {
		mapa_napis = "SREDNIA";
	}
	if (mapa == '3') {
		mapa_napis = "DUZA";
	}
	if (skora == '1') {
		skora_napis = "\n X   <---- Gatunek weza\n x\n x\n x\n x\n x\n x\n";
	}
	if (skora == '2') {
		skora_napis = "\n O   <---- Gatunek weza\n o\n o\n o\n o\n o\n o\n";
	}
	if (skora == '3') {
		skora_napis = "\n Q   <---- Gatunek weza\n *\n *\n *\n *\n *\n *\n";
	}

	cout << " Poziom   -> " << poziom_napis << endl << " Szybkosc -> " << predkosc_napis << endl << " Mapa     -> " << mapa_napis << endl << skora_napis << endl << endl;
	cout << "             POWODZENIA !" << endl << endl;

	Sleep(3000);
	system("cls");
}

void samouczek_wypisz() {
	cout << "           WITAJ !   " << endl << endl;
	Sleep(400);

	cout << "  Twoim zadaniem jest wcielenie sie   " << endl;
	cout << "  w postac jednego z 3 wezy" << endl << endl;
	Sleep(200);
	cout << "  Pyton Tygrysi  ->  Xxxxxxxx " << endl;
	cout << "  Pochodzi z Azji. Gatunek zagrozony.\n  Dorasta do 5-7 metrow. Dozywa 40 lat." << endl << endl;
	Sleep(200);
	cout << "  Boa Dusiciel   ->  Oooooooo " << endl;
	cout << "  Moze osiagac do 3.5 metra i zyc przez 37 lat.\n  Prowadzi nocny tryb zycia.\n  Wystepuje w Ameryce Poludniowej i Srodkowej" << endl << endl;
	Sleep(200);
	cout << "  Kobra          ->  Q******* " << endl;
	cout << "  Ma bardzo silnie jadowity jad.\n  Nie atakuja ludzi.\n  Zamieszkuje tropikalne i pustynne tereny Azji." << endl << endl;
	Sleep(200);
	cout << "  Nacisnij '1' aby przejsc dalej." << endl;
	dalej = '0';
	while (dalej != '1') {
		cin >> dalej;

		if (dalej == '1') {
			cout << "DALEJ";
			Sleep(20);
		}
		else {
			cout << endl << "ZLY ZAKRES ! " << endl << endl;
		}
	}
	dalej = '0';

	system("cls");
	cout << "  Celem twojej gry jest zebranie\n  jak najwiekszej ilosci punktow." << endl;
	cout << "  Masz do wyboru 2 rodzaje pozywienia:" << endl << endl;
	Sleep(200);

	cout << "  @  <-  ROBAK, dodaje ci 1 punkt gdy go zjesz." << endl << endl;
	Sleep(200);
	cout << "  %  <-  MUCHA, co pewnien czas pojawia sie na planszy\n         latajaca mucha, przed jej zjedzeniem musisz" << endl;
	cout << "         poczekac az usiadzie i nie bedzie sie ruszac.\n         Dodaje ci 2 punkty." << endl << endl;
	Sleep(200);
	cout << "  Nacisnij '1' aby przejsc dalej." << endl;
	while (dalej != '1') {
		cin >> dalej;

		if (dalej == '1') {
			cout << "DALEJ";
			Sleep(20);
		}
		else {
			cout << endl << "ZLY ZAKRES ! " << endl << endl;
		}
	}
	dalej = '0';
	system("cls");

	cout << "  Wybierz poziom trudnosci " << endl << endl;
	Sleep(200);
	cout << "  LATWY -> poziom gry,\n  mozesz przechodzic przez sciany,\n  nie kujesz sie wchodzac we wlasny ogon." << endl << endl;
	Sleep(200);
	cout << "  TRUDNY -> poziom gry,\n  NIE mozesz przechodzic przez sciany,\n  KUJESZ SIE wchodzac we wlasny ogon." << endl << endl;
	Sleep(200);
	cout << "  Nacisnij '1' aby przejsc dalej." << endl;
	while (dalej != '1') {
		cin >> dalej;

		if (dalej == '1') {
			cout << "DALEJ";
			Sleep(20);
		}
		else {
			cout << endl << "ZLY ZAKRES ! " << endl << endl;
		}
	}
	dalej = '0';
	system("cls");

	cout << "  Wybierz wielkosc planszy " << endl << endl;
	Sleep(300);
	cout << "  MALA    ->  Plansza 10x10, zalecana dla slabszych CPU" << endl << endl;
	Sleep(200);
	cout << "  SREDNIA ->  Plansza 20x20" << endl << endl;
	Sleep(200);
	cout << "  DUZA    ->  Plansza 30x30, zalecana do dobrej klasy PC" << endl << endl;
	Sleep(200);
	cout << "  Nacisnij '1' aby przejsc dalej." << endl;
	while (dalej != '1') {
		cin >> dalej;

		if (dalej == '1') {
			cout << "DALEJ";
			Sleep(20);
		}
		else {
			cout << endl << "ZLY ZAKRES ! " << endl << endl;
		}
	}
	dalej = '0';
	system("cls");
	cout << "  Wybierz szybkosc gry " << endl << endl;
	Sleep(300);
	cout << "  MALA    ->  Waz porusza sie z mala predkoscia." << endl << endl;
	Sleep(200);
	cout << "  SREDNIA ->  Predkosc srednia, optymalna do gry." << endl << endl;
	Sleep(200);
	cout << "  DUZA    ->  Duza predkosc, ma malej mapie bez szans." << endl << endl;
	Sleep(200);
	cout << "  Nacisnij '1' aby przejsc dalej." << endl;
	while (dalej != '1') {
		cin >> dalej;

		if (dalej == '1') {
			cout << "DALEJ";
			Sleep(20);
		}
		else {
			cout << endl << "ZLY ZAKRES ! " << endl << endl;
		}
	}
	dalej = '0';
	system("cls");
	cout << "  Dla najlepszych doznan wizualnych podczas gry,\n  ustaw podane wymiary terminala: " << endl << endl;
	Sleep(200);
	cout << "  SZEROKOSC: 60" << endl;
	Sleep(200);
	cout << "  WYSOKOSC:  35" << endl;
	Sleep(200);
	cout << "  CZCIAKA:   18" << endl << endl;
	Sleep(200);
	cout << "  Nacisnij '1' aby przejsc dalej." << endl;
	while (dalej != '1') {
		cin >> dalej;

		if (dalej == '1') {
			cout << "DALEJ";
			Sleep(20);
		}
		else {
			cout << endl << "ZLY ZAKRES ! " << endl << endl;
		}
	}
	dalej = '0';
	system("cls");
}

void Setup() {
	if (wyjscie == '5') {
		return;
	}

	// Wielkoœæ mapy wybierana w trybie manualnym
	if (mapa == '1') {
		szerokosc = 10;
		wysokosc = 10;
	}
	if (mapa == '2') {
		szerokosc = 20;
		wysokosc = 20;
	}
	if (mapa == '3') {
		szerokosc = 30;
		wysokosc = 30;
	}

	// Ustalenie pocz¹tkowych wartoœci gry
	Koniec_Gry = false;
	kierunek = 'S';       // Pocz¹tkowo w¹¿ nie porusza siê w ¿adnym kierunku
	wynik = 0;            // Kasowanie wyniku po ka¿ej rozgrywce
	ogon_dlugosc = 0;     // Kasowanie d³ugoœci wê¿a po ka¿ej rozgrywce

	// Pocz¹tkowa losowa pozycja wê¿a i robaka na mapie
	x = rand() % szerokosc;
	y = rand() % wysokosc;
	robak_X = rand() % szerokosc;
	robak_Y = rand() % wysokosc;
}

void Rysowanie() {
	system("cls");

	// Górna bariera mapy
	for (int i = 0; i < szerokosc + 2; i++) {
		cout << "#";
	}

	cout << "     Punkty --> " << wynik << endl;     // Punktacja

	// System pêtli gdzie 'i' oraz 'j' przeczesuj¹ wszystkie pozycje mapy, 
	// w zale¿noœci od po³o¿enia rysuje bariere, wê¿a lub po¿ywienie
	for (int i = 0; i < wysokosc; i++) {
		for (int j = 0; j < szerokosc; j++) {
			if (j == 0) {         // Lewa bariera
				cout << "#";
			}
			if (i == y && j == x) {      // Pozycjowanie g³owy wê¿a
				switch (skora) {
				case '1':
					cout << "X";
					break;
				case '2':
					cout << "O";
					break;
				case '3':
					cout << "Q";
					break;
				}

			}

			// Rysowanie po¿ywienia
			else if (i == robak_Y && j == robak_X) {
				cout << "@";
			}
			else if ((i == mucha_Y && j == mucha_X) && (wynik > 4)) {  // Specjalne po¿ywienie po przekroczeniu 4 punktów
				cout << "%";
			}

			else {
				bool pusta_przestrzen = false;

				for (int k = 0; k < ogon_dlugosc; k++) {

					if (ogon_X[k] == j && ogon_Y[k] == i) {     // Rysowanie ogona 
						switch (skora) {
						case '1':
							cout << "x";
							break;
						case '2':
							cout << "o";
							break;
						case '3':
							cout << "*";
							break;
						}
						pusta_przestrzen = true;
					}
				}
				if (!pusta_przestrzen) {      // Rysowanie spacji gdy nie jest rysowany ogon
					cout << " ";
				}
			}
			if (j == szerokosc - 1) {     // Prawa bariera
				cout << "#";
			}
		}
		cout << endl;
	}

	// Dolna bariera
	for (int i = 0; i < szerokosc + 2; i++) {
		cout << "#";
	}

	cout << endl << endl << "  Nacisnij 'x' aby zresetowac gre ";
}

// Funkcja wczytuj¹ca znak z klawiatury aby zmieniæ kierunek ruchu wê¿a
void Wejscie_klawiatura() {
	if (_kbhit()) {     // jeœli znak na klawiaturze jest naciœniêty to = 1
		switch (_getch()) {    // Kierowadnie wê¿em za pomoc¹ WSAD
		case 'a':
			kierunek = '1';
			break;
		case 'w':
			kierunek = '2';
			break;
		case 's':
			kierunek = '3';
			break;
		case 'd':
			kierunek = '4';
			break;
		case 'x':
			Koniec_Gry = true;       // Jeœli naciœniêty 'x' podczas gry to RESET
			break;
		}
	}
}

void Logika() {

	// Implementacja ci¹gn¹cego siê ogona za g³ow¹ wê¿a
	int ogon_X_kolejny = ogon_X[0], ogon_Y_kolejny = ogon_Y[0];
	int ogon_X_kolejny_bufor, ogon_Y_kolejny_bufor;
	// Gdy ogon = 1, ogon[0] przejmuje pozycje g³owy, a g³owa na switchu ni¿ej dostaje now¹ pozycjê
	ogon_X[0] = x;
	ogon_Y[0] = y;

	for (int i = 1; i < ogon_dlugosc; i++)    // Pêtla uruchamia siê dopiero gdy ogon >= 2
	{
		// "kolejny_bufor" przechowuje wspó³rzêdne "poprzedniego" cz³onu
		ogon_X_kolejny_bufor = ogon_X[i];
		ogon_Y_kolejny_bufor = ogon_Y[i];

		// 2 cz³on ogona przejmuje pozycje 1 cz³onu który jest za g³ow¹ 
		ogon_X[i] = ogon_X_kolejny;
		ogon_Y[i] = ogon_Y_kolejny;

		// gdy cz³onów jest > 2 pozycja wczeœniejszego cz³ona zapisywana jest do "kolejny" 
		// i w nastepnej iteracji pêtli przypisywana do nastêpnego cz³onu (pozycja 3 otrzymuje wspó³rzêdne pozycji 2)
		ogon_X_kolejny = ogon_X_kolejny_bufor;
		ogon_Y_kolejny = ogon_Y_kolejny_bufor;
	}

	// W zale¿noœci od kierunku kieruje wê¿em w pêtli podczas gry poprzez zmianê poszczeólnej wspórzednej
	switch (kierunek) {
	case '1':
		x--;
		break;
	case '2':
		y--;
		break;
	case '3':
		y++;
		break;
	case '4':
		x++;
		break;
	default:
		break;
	}

	// TRUDNY
	if (poziom == '2') {

		// Game over po wejœciu w œcianê
		if (y > wysokosc - 1 || y < 0 || x > szerokosc - 1 || x < 0) {
			cout << endl << "**** UDERZYLES W SCIANE ! ****" << endl << endl;
			Koniec_Gry = true;
		}

		// Game over po wejœciu w siebie
		for (int i = 0; i < ogon_dlugosc; i++) {
			if (ogon_X[i] == x && ogon_Y[i] == y) {
				cout << endl << endl << "**** ZJADLES SIEBIE ! ****" << endl << endl;
				Koniec_Gry = true;
			}
		}
	}

	//£ATWY
	if (poziom == '1') {

		// Przenikanie przez œciany
		if (x >= szerokosc) x = 0; else if (x < 0) x = szerokosc - 1;
		if (y >= szerokosc) y = 0; else if (y < 0) y = szerokosc - 1;
	}

	// Tworzenie jedzenia gdy poprzednie zostanie zjedzone 
	if (x == robak_X && y == robak_Y) {
		wynik += 1;
		robak_X = rand() % szerokosc;
		robak_Y = rand() % wysokosc;
		ogon_dlugosc++;
	}

	// Tworzenie specjalnego jedzenia gdy poprzednie zostanie zjedzone 
	if (x == mucha_X && y == mucha_Y) {
		wynik += 2;
		ogon_dlugosc = ogon_dlugosc + 2;
		// Po zjedzeniu mucha znika z planszy a¿ do ponownego spe³nienia warunków pojawienia siê
		mucha_X = 50;
		mucha_Y = 50;
	}
}

int main() {
	// Definicja parametrów gry w trybie automatycznym
	Rozgrywka Waz_1('1', '1', '3', '1');
	Rozgrywka Waz_2('1', '2', '2', '2');
	Rozgrywka Waz_3('2', '3', '3', '3');

	while (1) {

		if (wyjscie != '5') {
			system("cls");
			cout << "                       THE SNAKE - GAME" << endl << endl << endl;
			ikona_wypisz();    // Grafika wê¿a
			Sleep(5000);
			system("cls");
		}
		system("cls");
		wyjscie = '0';

		while (wyjscie != '5') {
			menu_wypisz();

			if (menu == '3') {
				samouczek_wypisz();
				menu_wypisz();
			}

			if (menu == '1') {
				poziom_trudnosci_wypisz();
				szybkosc_wypisz();
				mapa_wypisz();
				skora_wypisz();
				podsumowanie_wypisz();

				Setup();
			}

			if (menu == '2') {
				waz_wypisz();
				// Wczytanie ustawieñ gry za pomoc¹ getterów do klasy Rozgrywka
				if (waz == '1') {
					poziom = Waz_1.get_poziom();
					predkosc = Waz_1.get_predkosc();
					mapa = Waz_1.get_mapa();
					skora = Waz_1.get_skora();
				}
				if (waz == '2') {
					poziom = Waz_2.get_poziom();
					predkosc = Waz_2.get_predkosc();
					mapa = Waz_2.get_mapa();
					skora = Waz_2.get_skora();
				}
				if (waz == '3') {
					poziom = Waz_3.get_poziom();
					predkosc = Waz_3.get_predkosc();
					mapa = Waz_3.get_mapa();
					skora = Waz_3.get_skora();
				}

				podsumowanie_wypisz();
				Setup();
			}

			if (menu == '4') {
				exit(0);
			}

			while (!Koniec_Gry && wyjscie != '5') {
				Rysowanie();
				Wejscie_klawiatura();
				Logika();

				// Specjalne po¿ywienie
				if (((wynik % 7) == 0) && (wynik > 6)) {   // gdy wynik jest wiêkszy od 6 i podzielny przez 7
					mucha_X = rand() % szerokosc;
					mucha_Y = rand() % wysokosc;
				}

				if (predkosc == '1') {
					Sleep(50);
				}
				if (predkosc == '2') {
					Sleep(30);
				}
				if (predkosc == '3') {
					Sleep(3);
				}
			}
			if (Koniec_Gry == 1) {
				Sleep(3500);
				system("cls");
			}
			if (wyjscie == '5') {
				Sleep(100);
			}
		}
	}

	return 0;
}