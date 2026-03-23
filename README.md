This project creates a rental environment for university, it can be used by students and teachers, it supports 3 equipments types.
I tried to design this project of Rentals service so it is readable, each class has its own goal, it is easily modifiable without much hardcoding.
I divided main parts of the projects in directories:
Users for user related classes;
Equipments for equipment related classes;
logic for logic related classes;
interfaces for interfaces;

I implemented various interfaces to support my RentalService class which is responsicle for buisness logic.
I also decided to create ConsoleReporter class to not put console printing inside buisness logic class such as RentalService.
I used properties insted of fields to save time and make code more readable than it would be if i used filds with geters and seters. 
I used abstract classes for user and equipment so is is east to expand this project if needed by adding new user or equipment types.
