# Pen Plotter

## Members
Sabrina Johnson, Tiffany Cai, Al-kesna Foster, John Abramo, Nick Brown

## Software
- [Zeptoforth](https://github.com/tabemann/zeptoforth)

## Hardware
- Mini - RepRap Arduino-Mega-Compatible Motherboard (a.k.a. Mini-Rambo)
- Raspberry Pi Pico 2 (RP2350)
- Lulzbot Mini

## Compiling/Running
After cloning the repo run the following command:
  ``` bash
  chmod +x bundle.sh
  ```
Next run the "compilation" script using the following:
  ``` bash
  ./bundle.sh
  ```
This will generate bundle.fs which is what you will send to the Pico 2 using the `cat` command.
  ``` bash
  cat bundle.fs > /dev/ttyACM0
  ```
Finally, run screen and hit [ENTER]. The zeptoforth word `main` will begin the user prompt.

** Note: You can also run main.fs in gforth if you do not have the Pico flashed. This works temporarily as we have not begun implementing motor primitives.
