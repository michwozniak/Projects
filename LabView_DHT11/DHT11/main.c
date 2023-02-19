/*
 * DHT11.c
 *
 * Created: 15.11.2021 15:50:08
 * Author : Michal
 */ 

#define F_CPU 16000000UL // Clock Speed ATmega328PB 16 MHz

#include <avr/io.h>
#include <stdlib.h>
#include <util/delay.h>
#include "usart.h"

#define BAUD 9600
#define MYUBRR F_CPU/16/BAUD-1 

#define DHT11_PIN PORTD2         // PIN PD2
uint8_t c=0,I_RH,D_RH,I_Temp,D_Temp,CheckSum;


void Request()				/* Microcontroller send start pulse/request */
{
	DDRD |= (1<<DHT11_PIN);
	PORTD &= ~(1<<DHT11_PIN);	/* set to low pin */
	_delay_ms(18);			/* wait for 18ms */
	PORTD |= (1<<DHT11_PIN);	/* set to high pin */
}

void Response()				/* receive response from DHT11 */
{
	DDRD &= ~(1<<DHT11_PIN);
	while(PIND & (1<<DHT11_PIN));
	while((PIND & (1<<DHT11_PIN))==0);
	while(PIND & (1<<DHT11_PIN));
}

uint8_t Receive_data()			/* receive data */
{
	for (int q=0; q<8; q++)
	{
		while((PIND & (1<<DHT11_PIN)) == 0);  /* check received bit 0 or 1 */
		_delay_us(30);
		if(PIND & (1<<DHT11_PIN))/* if high pulse is greater than 30ms */
		c = (c<<1)|(0x01);	/* then its logic HIGH */
		else			/* otherwise its logic LOW */
		c = (c<<1);
		while(PIND & (1<<DHT11_PIN));
	}
	return c;
}

int main(void)
{
	USART_Init(MYUBRR);
	char data[5];
	_delay_ms(1000); //stabilizacja zasilania

	while(1)
	{
		Request();		/* send start pulse */
		Response();		/* receive response */
		I_RH=Receive_data();	/* store first eight bit in I_RH */
		D_RH=Receive_data();	/* store next eight bit in D_RH */
		I_Temp=Receive_data();	/* store next eight bit in I_Temp */
		D_Temp=Receive_data();	/* store next eight bit in D_Temp */
		CheckSum=Receive_data();/* store next eight bit in CheckSum */
		
		if ((I_RH + D_RH + I_Temp + D_Temp) != CheckSum){
			USART_PutS("Error");
		}
		else
		{
			itoa(I_RH,data,10);
			USART_PutS(data);

			itoa(I_Temp,data,10);
			USART_PutS(data);
		}
		_delay_ms(1000);
	}
}