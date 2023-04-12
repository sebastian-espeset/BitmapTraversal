# BitmapTraversal
## This is a C# console program that prompts the user to enter a file path for a .bmp, and then returns the center coordinates for any 3X3 red squares it finds.
## It uses the System.Drawing namespace to construct a bitmap and then uses the GetPixel method to test requirements. There may be some redundancy there. 
## *I have taken some shortcuts though.*
> - The algorithm doesn't currently check explicitly for *red* pixels, just that they aren't black or white. 
> - The program will break if a red square lays on an edge
