using EmployeeWageComputation;

EmpWageBulderObject dMart = new EmpWageBulderObject("DMart", 20, 4, 10);
EmpWageBulderObject reliance = new EmpWageBulderObject("Reliance", 10, 4, 20);
dMart.EmployeeAttendence();
Console.WriteLine(dMart.toString());
reliance.EmployeeAttendence();
Console.WriteLine(reliance.toString());

