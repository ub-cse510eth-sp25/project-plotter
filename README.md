# Dotty: The Pen Plotter

## Members
Sabrina Johnson, Tiffany Cai, Al-kesna Foster, John Abramo, Nick Brown

## Software
- [Zeptoforth](https://github.com/tabemann/zeptoforth)

## Hardware
- Double sided PCB perf board
- [Raspberry Pi Pico 2 (RP2350)](https://www.digikey.com/en/products/detail/raspberry-pi/SC1631/24627136)
- [A4988](http://hiletgo.com/ProductDetail/1952643.html) stepper motor drivers.
- [945-R-78K5.0-1.0-ND](https://www.digikey.com/en/products/detail/recom-power/R-78K5-0-1-0/18093047) 5-Volt switching regulator
- 3D-Printed pen holder (made by @jmabramo)
- Parts and frame from a Lulzbot Mini 3d Printer
  - Stepper motors
  - end-stop switches
  - power supply (24-Volt)

## Setup and Word Dictionary
This is explained in detail in `./doc` directory of the repository.

## Compiling/Running
After cloning the repository, change directories into it and run the following command:
``` bash
chmod +x bundle.sh
```
Next run the "compilation" script using the following:
``` bash
./bundle.sh
```
This will generate bundle.fs which is what you will send to the Pico 2.  

To load the `bundle.fs` You will need the `codeload3.py` utility from the [Zeptoforth utils](https://github.com/tabemann/zeptoforth/blob/master/utils/codeload3.py) directory,  
after retrieving it, you will need to make it executable the same way you did for `bundle.sh`.  

Now, you can plug the pico 2 into your computer, find it's path in `dev`, and run the following command.
``` bash
codeload3.py -p [path to pico] serial bundle.fs
```
Finally, you can use screen to attach to the pico itself,  
```bash
screen [path to pico]
```
Typing the zeptoforth word `main` and hitting `ENTER` will begin the user prompt.

