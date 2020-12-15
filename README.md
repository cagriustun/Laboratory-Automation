##Laboratory Analysis Document

###Laboratory
- The laboratory will include employees.
- The laboratory will have ID, name and type.

###Employee
- Employees will include tests.
- Employees' features will be ID, name, surname, and the laboratory they work in.

###Test
- The features of the tests will be ID, name, type and description.

###Business Rules
- Each laboratory can have more than one employee.
- Each employee can work in only one laboratory.
- Each employee can work on one or more tests.
- Each test can belong to only one employee.
- In order to add employees to the automation, the laboratory must already be added.
- If there is no employee in the automation, a new test cannot be created.
- When a laboratory is deleted, employees in that laboratory are deleted from automation.
- If an employee is deleted, It will be deleted from all tests It has with that employee.
