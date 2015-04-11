Mnemonics documentation
-------------------
mnemonic | meaning | argument | bytecode |
:--------|:--------|:--------:|---------:|
LDA | Assign a value to the A register | {value} | $01
LDX | Assign a value to the X register | {value} | $02
ST{#} | Where {#} is replace by a register identifier see the examples inside the examples folder for help you to understand this | {value} | $03
END | All B32 programs ***MUST*** have an end statement and it must be the last line in the program | Program entry point label | $04
