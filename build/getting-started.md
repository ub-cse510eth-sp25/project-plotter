# Setting Up Forth on Raspberry Pi Pico RP2350

This guide covers the process of setting up zeptoforth on a Raspberry Pi Pico RP2350.

## UF2 File Information

UF2 is a file format developed by Microsoft for updating firmware on embedded devices via USB. It is a binary file format that contains both the firmware image and metadata necessary for flashing the device.

We will be using the UF2 file called `zeptoforth_full_usb-1.12.0.3.uf2`. It is located in the build directory.

## Linux Setup Guide

### 1. Prepare the Pico for Flashing

1. Locate the BOOTSEL button on your Raspberry Pi Pico (the small white button by the top left of the board)
2. Hold down the BOOTSEL button
3. While holding BOOTSEL, connect the Pico to your computer via USB
4. Continue holding BOOTSEL for 3-5 seconds after connecting
5. Release the button

The Pico should now appear as a USB mass storage device (like a USB drive) named "RP2350". If you open your file manager, it sill be present on the left side of the application with two files present.

### 2. Check if the Pico is Mounted

Verify that your computer has detected the Pico in bootloader mode:

```bash
ls -la /media/$USER/
```

You should see "RP2350" listed as a mounted drive.

Alternatively, use:

```bash
lsblk
```

Look for a new device (often "sda1" or similar) with the mount point showing RP2350.

### 3. Flash the Firmware

Copy the zeptoforth firmware to the Pico (execute the following commands from the build directory): 

```bash
sudo cp zeptoforth_full_usb-1.12.0.3.uf2 /media/$USER/RP2350/
```

**Important**: Make sure to use the firmware specifically for RP2350. I added the binary I used. You can also find all binaries at the following webpage: https://github.com/tabemann/zeptoforth/releases

After copying, the Pico will automatically disconnect from your computer as it installs the firmware, then reconnect as a serial device (i.e. /dev/ttyACM0).

### 4. Connect to the Pico via Serial

Install screen if you don't have it already:

```bash
sudo apt install screen
```

Find the serial device:

```bash
ls /dev/ttyACM*
```

Connect to the Pico:

```bash
screen /dev/ttyACM0 115200
```

(Replace ttyACM0 with the correct device if different)

**Note**: 115200 represents the baud rate for serialcommunication between your computer and the Raspberry Pi Pico. Baud rate is the speed of data transmission measured in bits per second (bps). This rate is apparently standard for microcrontrollers/embedded systems.

### 5. Test the Forth Environment

Once connected, press Enter to get a prompt. Try some basic Forth commands:

```forth
2 3 + .  \ Should print 5
```

### 6. Exit the Terminal

To exit screen:
1. Press `Ctrl+A`
2. Then press `K`
3. When prompted "Really kill this window [y/n]", press `y`

### 7. Troubleshooting

If screen is terminating immediately:
```bash
sudo screen /dev/ttyACM0 115200
```

If the Pico isn't recognized as a serial device, make sure you used the correct firmware for the RP2350.

## macOS Setup Guide (Update as needed, this was what I found)

### 1. Prepare the Pico for Flashing

1. Locate the BOOTSEL button on your Raspberry Pi Pico (the small white button by the top left of the board)
2. Hold down the BOOTSEL button
3. While holding BOOTSEL, connect the Pico to your computer via USB
4. Continue holding BOOTSEL for 3-5 seconds after connecting
5. Release the button

The Pico should now appear as a USB mass storage device (like a USB drive) named "RP2350" or "RPI-RP2".

### 2. Check if the Pico is Mounted

The Pico should appear on your desktop or in Finder as a removable drive.

To verify via Terminal:

```bash
ls /Volumes/
```

You should see "RP2350" or "RPI-RP2" listed.

### 3. Flash the Firmware

Copy the zeptoforth firmware to the Pico:

```bash
sudo cp zeptoforth_full_usb-1.12.0.3.uf2 /Volumes/RP2350/
```

After copying, the Pico will automatically disconnect from your computer as it installs the firmware, then reconnect as a serial device.

### 4. Connect to the Pico via Serial

Find the serial device:

```bash
ls /dev/tty.*
```

Look for something like `/dev/tty.usbmodem14301` (the exact name will vary).

Connect to the Pico using screen (pre-installed on macOS):

```bash
screen /dev/tty.usbmodem14301 115200
```

(Replace the device name with the one you found)

### 5. Test the Forth Environment

Once connected, press Enter to get a prompt. Try some basic Forth commands:

```forth
2 3 + .  \ Should print 5
```

### 6. Exit the Terminal

To exit screen on macOS:
1. Press `Ctrl+A`
2. Then press `Ctrl+\`
3. When prompted "Really quit and kill all your windows [y/n]", press `y`

### 7. Troubleshooting

If the serial device isn't showing up, try:
```bash
ls /dev/cu.*
```
Some terminal programs work better with cu.* devices than tty.* devices.
