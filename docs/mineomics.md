The following mnemonics are available
-------------------
*LDA $01 - Assigns a value to our A register LDA #$2A Assigns the hex value $2A to the A register
*LDX $02 - Assigns a value to our X register LDX #16000 Assigns the number 16,000 to the X register
*STA $03 - Stores the value of the A register to a memory location
*STA ,X - Stores the value of the A register to the memory location pointed to by the X register
*END $04 - Terminates the B32 program END START Terminate the program and tell our assembler that execution of our program should start at the START label  
