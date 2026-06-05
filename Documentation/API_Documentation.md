# Finance Billing Analytics API Documentation

Base URL

https://localhost:7032/api

## Authentication

POST /Auth/Login

Request

{
"email":"[admin@finance.com](mailto:admin@finance.com)",
"password":"Admin123"
}

Response

{
"token":"JWT_TOKEN"
}

---

## Invoice APIs

GET /Invoice

Returns all invoices.

GET /Invoice/{id}

Returns invoice by id.

POST /Invoice

Creates invoice.

Authorization Required:
Bearer Token

Role:
Admin

---

## Payment APIs

GET /Payment

Returns all payments.

GET /Payment/{id}

Returns payment by id.

POST /Payment

Creates payment.

Authorization Required:
Bearer Token

Role:
Admin
