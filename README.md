# Electricity Calculator - NugetPackage
This is a Comprehensive Library created to help in Electricity Solutions with functions to help perform electrical calculations such as calulating resistor values, adding resistor values in parallel and series, evaluating Electrical Power, Capacitance etc.

## How to Use the Library/Nuget package
- Install the Nuget package into your project
- Add the Library Refrences where needed 
`using ElectricityCalculator;`

- To Add Resistor values in Series, Simply Call the Add Static method and pass in an array of the values:
`Resistor.AddParallel(double[] values)`
`Resistor.AddSeries(double[] values)`

- To calculate resistor value based on resistance code, instantiate the resistor class and initialize the properties such as color bands, multiplier color, tolerance color and temperature colors. 
- Call the Calulate method and pass in the resistor obeject created.
`resistor.CalulateColorCode(resistor)`

## Classes Used
The following classes were implemented and can be called.
Resistor.cs - Containes properties that can be set to represent a given resistor with resistor values.

### Properties - 
``public ResistorBands BandType
 decimal Value
 Colors Band1 
 Colors Band2
 Colors Band3
 Colors Multiplier
 Colors Tolerance
 Colors TemperatureCoefficient { get; set; }``


### Methods
`public static double AddSeries(double[] values)`
 - Takes in an array of resistor values and returns the result after adding serially
 
 `public static double AddParallel(double[] values)`
 - Takes in an array of resistor values and returns the result after adding parallelly
 
 `public string CalulateColorCode(Resistor resistor)`
 - Takes in a Resistor object and Calulates the value of the resistor based on the Color Bands

### Enums
#### ResistorBands
`public enum ResistorBands
    {
       _3Band = 1,
        _4Band, 
        _5Band, 
        _6Band }`
    
    
#### ColorCodes
`public enum Colors
    {
        Black = 0,
        Brown,
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Violet,
        Grey,
        White,
        Gold,
        Silver }`
