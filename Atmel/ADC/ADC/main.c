/*
 * ADC.c
 *
 * Created: 11/14/2017 11:24:19 AM
 * Author : user-10
 */ 

#define F_CPU 16000000UL
#include <avr/io.h>
#include <util/delay.h>
#define BAUDRATE 19200
#define BAUD_PRESCALLER(((F_CPU/ (BAUDRATE * 16UL)))) -1
void kanta()
{
		ADMUX=(1<<REFS0);
		ADCSRA=(1<<ADEN)|(1<<ADPS0)|(1<<ADPS1)|(1<<ADPS2);


}
uint16_t Read_ADC(uint8_t ch)
{
	ch &= 0b00000111;
	ADMUX |=ch;
	
	ADCSRA |= (1<<ADSC);
	while (ADCSRA & (1<<ADSC));
	return ADC;
}



int main()
{
    DDRB=0xff;
	kanta();
	//ADMUX=(1<<REFS0);
	//ADCSRA=(1<<ADEN)|(1<<ADPS0)|(1<<ADPS1)|(1<<ADPS2);
	
    while (1) 
    {
		uint16_t Write=Read_ADC(0);
		if( Write>=512)
		PORTB |=(1<<0);
		else
		PORTB &=~(1<<0);
		_delay_ms(100);
    }
	
}

