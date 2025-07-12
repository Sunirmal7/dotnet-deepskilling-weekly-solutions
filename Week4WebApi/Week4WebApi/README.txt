Week 4 Web API - Update Employee

Instructions:
1. Run the Web API project.
2. Use Swagger or Postman.
3. URL: PUT /api/employee/{id}
   Example: /api/employee/1

Test Cases:
- ID <=0: Returns 400 BadRequest
- Invalid ID: Returns 400 BadRequest
- Valid ID: Returns 200 OK with updated employee data

JSON Body example:
{
  "id": 1,
  "name": "Updated John",
  "salary": 7500
}
