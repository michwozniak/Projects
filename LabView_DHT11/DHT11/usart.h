/*
 * usart.h
 *
 * Created: 16.11.2021 12:14:36
 *  Author: Micha³
 */ 

#ifndef USART_H_
#define USART_H_

void USART_Init( unsigned int ubrr); // Inicjalizacja UART
void USART_PutC( char data ); // Wysylamy pojedynczy znak
void USART_PutS( char * s); // Wysylamy string, ciag znakow
unsigned char USART_Receive( void ); // Odbiera wyslane dane 

#endif /* USART_H_ */