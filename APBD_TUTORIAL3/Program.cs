using APBD_TUTORIAL3.Entities;
//initialization
UERepository ueRepository= new UERepository();
RentalService rentalService = new RentalService(ueRepository);
ConsoleReporter consoleReporter = new ConsoleReporter(rentalService);
//adding equipment
rentalService.AddEquipment(new Laptop("Lenovo zb14", "in good state", 32, "rtx 4070ti"));
rentalService.AddEquipment(new Camera("Nixon m4", "in moderate state", 108, 0.4));
rentalService.AddEquipment(new Printer("Philips ultra", "Old", 30, true));
//adding users
rentalService.AddUser(new Student(32907, "Oleksandr", "Iievliev", 2));
rentalService.AddUser(new Student(32656, "John", "Doe", 3));
rentalService.AddUser(new Teacher(102, "ALex", "Brown", 4.5));
//renting
rentalService.RentEquipment(32907,1, new DateTime(2026,03,24));
rentalService.RentEquipment(32907,2, new DateTime(2026,03,24));
rentalService.RentEquipment(32907,3, new DateTime(2026,03,24));
consoleReporter.GenerateShortSummary();
consoleReporter.DisplayAvailableEquipment();