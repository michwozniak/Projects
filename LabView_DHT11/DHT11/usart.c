/*
 * usart.c
 *
 * Created: 15.11.2021 16:32:12
 *  Author: Micha³
 */ 

#include <avr/io.h>
#include <stdlib.h>
#include <util/delay.h>

#include "usart.h"

void USART_Init( unsigned int ubrr) // Inicjalizacja USART
{
	/*Set baud rate */
	UBRR0H = (unsigned char)(ubrr>>8);
	UBRR0L = (unsigned char)ubrr;
	/*Enable receiver and transmitter */
	UCSR0B = (1<<RXEN0)|(1<<TXEN0);
	/* Set frame format: 8data, 1stop bit */
	UCSR0C = (3<<UCSZ00);
}

void USART_PutC( char data ) // ZNAK CHAR
{
	/* Wait for empty transmit buffer */
	while ( !( UCSR0A & (1<<UDRE0)) );
	/* Put data into buffer, sends the data */
	UDR0 = data;
}

void USART_PutS( char * s) // STRING - CI¥G CHAR'ÓW
{
	while( *s ) USART_PutC( *s++ );
}

unsigned char USART_Receive( void )
{
	/* Wait for data to be received */
	while ( !(UCSR0A & (1<<RXC0)) );
	/* Get and return received data from buffer */
	return UDR0;
}