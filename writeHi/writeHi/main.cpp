#include "main.h"
#include <stdio.h>

extern "C"
{
 // __declspec(dllexport) void DisplayHelloFromDLL()
void DisplayHiFromDLL()
  {
    printf ("This is Hi from dll !\n");
  }
}