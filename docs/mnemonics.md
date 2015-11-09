Mnemonics documentation
-------------------
mnemonic | meaning | argument(s) | byte code |
:--------|:--------|:--------:|---------:|
LDA | Assign a value to the A register | {value} | 0x1
LDX | Assign a value to the X register | {value} | 0x2
ST{#} | Replace {#} with your desired register to store Eg: STA stores the A register | {value} | 0x3
JMP | Jump to a specific code section | {section} | 0x4
END | All B32 programs ***MUST*** have an end statement and it must be the last line in the program | void | 0x65
