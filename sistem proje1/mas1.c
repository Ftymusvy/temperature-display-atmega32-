#include <io.h>
#include <mega32.h>
#include <delay.h>
#include <stdlib.h>
#include <string.h>
#include <stdio.h>



void adc_configuration(){
 ADMUX |= (1<<REFS1)|(1<<REFS0);     // Set reference voltage (internal 5V)
 ADCSRA |= (1<<ADPS2)|(1<<ADPS1)|(1<<ADEN);    //Enable ADC, and bits are set to 111 for the ADC clock
}



unsigned int temp(){ 
ADCSRA |=(1<<ADSC);     // Start ADC conversion
while ((ADCSRA & (1<<ADIF))==0);    // Wait for conversion to complete (ADIF flag)
ADCSRA |=(1<<ADIF);     // Clear the ADIF flag
return ADCW;   // Return the ADC conversion result (10-bit unsigned integer)
}



void main(void)
{
char str[10];
float T;
DDRA = 0x00 ;   // Set PORTA as input
PORTA = 0x00 ;
UCSRB = 1 <<TXEN; // Enable USART transmitter
UCSRC = 0b10000110;  // set it for 8_bit
UBRRL= 71;  // baud rate

while (1)
    {
    adc_configuration();    // ADC function              
    T = temp();             // Read temperature
    T=(T*256)/1023;        // Convert ADC value to temperature
    ftoa(T,1,str);         // Convert temperature to string
    puts(str);             //print temperature
    delay_ms(500);
    

    }
}
