# Those are the reserved section labels
start (Must be present, your program entry point so you can redirect to other locations)

inir (Initialization routine IE, the first block of code executed even bore start, use for memory allocation for example)

endr (End program routine IE, the last thing to execute called after END mnemonic is reached must be declared before it though, use to remove memory allocation for example)

flags (Non code block just special purpose mnemonics, flags basically that takes no arguments return nothing but change the VM execution behaviour)
# Flags
GABGC (Basically a very primitive garbage collection system)

AUTODEINIT (Auto remove every trace of your program)

more to come
