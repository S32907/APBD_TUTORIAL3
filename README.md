How to run this project: 
to run this project we need to do the following in main create UERepository pass it as parametr to RentalService constructor, pass rentalService as a
parametr to ConsoleReporter constructor. After that we can accses full functionality of the project via instance of rentalService or ConsoleReporter.
Possible methods can be seen in corresponding interfaces.

important note: to retun equipment you must specify its due date that was given to it during creation, as a third parametr, it acts sort of like id.

Description
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
