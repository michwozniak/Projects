.include "m328pbdef.inc"

; Wykorzystane 2 przerwania INT0 i INT1
.org 0
	jmp main 
.org INT0addr
	rjmp int0_isr
.org INT1addr
	rjmp int1_isr

;------- main ----------
main:
	ldi r16, LOW(RAMEND) 
	out spl, r16
	ldi r16, HIGH(RAMEND)
	out sph, r16

	ldi r16, 255
	ldi r17, 0

	out ddrc, r17 ; GUZIKI
	out ddrd, r17 ; CZUJKI

	out ddrb, r16 ; LED
	out ddre, r16 ; LED 3_czujnik
	out portc, r16 ; pull-up PORT E - GUZIKI
	out portd, r16 ; pull-up PORT D - CZUJKI

	;PD2 - czujnik 30cm
	;PD3 - czujnik 20 cm
	;PD0 - czujnik 5 cm

start:
	sbis PIND, 0   ; Skok do czujnik 3 jak wykryje ruch
	rjmp czujnik_3 

	cbi porte, 0 ; Gasi diody 3 czujnika jak nie s¹ u¿ywane

	sbis PIND, 3 ; Wywo³uje funkcje 'czujnik_2' jeœli czujnik 20 cm coœ wykryje
	call czujnik_2

	sbis PIND, 2 ; Wywo³uje funkcje 'czujnik_1' jeœli czujnik 30 cm coœ wykryje
	call czujnik_1

	sbis PINC, 0   ; TEST diod i buzzera pod guzikiem S2
	rjmp guzik_TEST

	; Wyzerowanie ledów
	out porte, r17
	out portb, r17

	; Jeœli guzik S1 wciœniêty, przechodzi w stan wstrzymania
	sbis PINC, 1
	rjmp turn_OFF

	rjmp start 

guzik_TEST:
	push r25
	ldi r25, 63 ; 63 bo 6 diod na stan wysoki, binarnie '111111'
	out portb, r25 ; Zapala diody od czujników 1 i 2
	sbi pine, 0 ; Zapala diody od czujnika 3
	sbi pine, 1 ; Czerwon¹ i zielon¹
	call buzzer1 ; Wywo³uje buzzer
	pop r25
	ret

turn_OFF:
	; Wy³¹cza przerwania
	ldi r20, (0<<int0)
	out eimsk, r20 
	ldi r21, (0<<int1)
	out eimsk, r21 

	; Jeœli wciœniêty guzik S3 to czujki wracaj¹ do pracy 
	sbis PINC, 2
	rjmp start


	; "LEDOWY W¥¯"
	push r22
	push r23
	push r24
	push r25
	push r26
	push r27
	push r28

	ldi r22, 1
	ldi r23, 3
	ldi r24, 6
	ldi r25, 12
	ldi r26, 24
	ldi r27, 48
	ldi r28, 96

	; Przechodzi do kolejnych stanów, poprzedzonych krótkim czasem wstrzymania
	call wait
	out portb, r22
	call wait
	out portb, r23
	call wait
	out portb, r24
	call wait
	out portb, r25
	call wait
	out portb, r26
	call wait
	out portb, r27
	call wait
	out portb, r28

	pop r28
	pop r27
	pop r26
	pop r25
	pop r24
	pop r23
	pop r22
		
	jmp turn_OFF


czujnik_2:
	; Dezaktywacja przerwania 1 czujnika
	ldi r20, (0<<int0)
	out eimsk, r20 
	; Aktywacja przerwania czujki 2, aktywowana stanem niskim 0
	ldi r21, (1<<int1)
	out eimsk, r21 
	ldi r21, (0<<isc11)|(0<<isc10)
	sts eicra, r21 
	sei 
	ret

czujnik_1:
	; Dezaktywacja przerwania 2 czujnika
	ldi r21, (0<<int1)
	out eimsk, r21 
	; Aktywacja przerwania czujki 1, aktywowana stanem niskim 0
	ldi r20, (1<<int0)
	out eimsk, r20 
	ldi r20, (0<<isc01)|(0<<isc00)
	sts eicra, r20 
	sei 
	ret

czujnik_3:
	sbi porte, 0 ; Zapala czerwon¹ 
	call wait_dioda ; Odczekuje czas
	cbi porte, 0 ; Gasi czerwon¹ 

	call buzzer1 ; Wywo³anie buzzera

	sbi porte, 1 ; Zapala zielon¹
	call wait_dioda ; Odczekuje czas
	cbi porte, 1 ; Gasi zielon¹ 

	call buzzer1; Wywo³anie buzzera
	
	rjmp start ; Idzie 'start', jak dalej czujka 3 wykrywa ruch to wraca do tej pêtli

;-------PÊTLE PRZERWAÑ-------
int0_isr:
	push r25

	; Czujka 1 nie dzia³a, jeœli czujka 2 albo 3 jest aktywowana
	sbis pind, 0 ; WyjdŸ z funkcji je¿eli czujka 3 - 5cm, jest aktywowana
	ret

	sbis pind, 3 ; WyjdŸ z funkcji je¿eli czujka 2 - 20cm, jest aktywowana
	ret

	ldi r25, 7
	sbis pind, 2 ; JeŸli 1 czujka aktywowana, zapal po³owe ¿ó³tych diod
	out portb, r25

	call buzzer1 ; Wywo³anie buzzera1

	pop r25
	reti

int1_isr:
	push r25
	
	; Czujka 2 nie dzia³a, jeœli czujka 3 jest aktywowana
	sbis pind, 0 ; WyjdŸ z funkcji je¿eli czujka 3 - 5cm, jest aktywowana
	ret

	ldi r25, 63
	sbis pind, 3 ; JeŸli 2 czujka aktywowana, zapal wszystkie ¿ó³te diody
	out portb, r25

	call buzzer2 ; Wywo³anie buzzera2

	pop r25
	reti

;-------BUZZERY-------

; Buzzer czujnika 1
buzzer1:
	push r18
	push r19

	sbi pine, 2 ; Ustawienie poziomu wysokiego na buzzer
	ldi r19, 70 
	loop3:
		ldi r18, 20
		nop           
		loop4:
			nop           
			dec r18      
			brne loop4   
		dec r19    
		brne loop3	
	cbi pine, 2 ; Ustawienie poziomu niskiego na buzzer

	pop r19
	pop r18
	ret

; Buzzer czujnika 2, o innej czêstotliwoœci dzwiêku
buzzer2:
	push r18
	push r19

	sbi pine, 2 ; Ustawienie poziomu wysokiego na buzzer
	ldi r19, 70 
	loop9:
		ldi r18, 10 
		nop           
		loop8:
			nop           
			dec r18      
			brne loop8  
		dec r19    
		brne loop9	
	cbi pine, 2 ; Ustawienie poziomu niskiego na buzzer

	pop r19
	pop r18
	ret

; Ustawienie szybkoœci migania dod zielonej i czerwonej po aktywacji czujnika 3 - 5cm
wait_dioda:
	push r18  
	push r19  
	push r20  

	lds r20, 5  
	loop111:		
		ldi r18, 10
		call buzzer2 ; Wprowadza buzzer w pêtli podczas czekania pomiêdzy prze³¹czaniem siê diod czerwonej i zielonej
		loop222:
			ldi r19, 45
			nop       
				loop333:
					dec r19  
					brne loop333 
			dec r18     
			brne loop222   
		dec r20     
		brne loop111  

	pop r20
	pop r19
	pop r18

	ret  

; Ustawienie szybkoœci "wê¿a ledowego" w stanie wstrzymania pracy czujników
wait:
	push r18  
	push r19  
	push r20  

	lds r20, 5 
	loop11:
		ldi r18, 4
		nop        
		loop22:
			ldi r19, 255
			nop       
				loop33:
					dec r19  
					brne loop33 
			dec r18     
			brne loop22   
		dec r20     
		brne loop11  

	pop r20
	pop r19
	pop r18

	ret  