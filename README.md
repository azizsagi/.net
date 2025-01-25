# Companies House API Integration

## Overview
The **Companies House API Integration** is a RESTful service that interacts with the Companies House API to retrieve, manage, and process company data in the United Kingdom. This integration provides seamless access to publicly available company information, ensuring developers can build applications with real-time and accurate data from Companies House.

This project demonstrates how to consume and utilize the Companies House API using .NET technologies, focusing on efficient data handling, secure communication, and easy extensibility.

---

## Features
- **Company Search**: Search for companies by name or registration number.
- **Company Details**: Retrieve detailed information about a specific company.
- **Filing History**: Access a company’s filing history and documents.
- **Officers Information**: Fetch details about company officers.
- **Secure Integration**: Ensure secure API communication with authentication via API keys.
- **Error Handling**: Robust error-handling mechanisms for API responses.

---

## Technologies Used
- **.NET 8.0**: For building the RESTful service.
- **HttpClient**: For making API calls to Companies House.
- **Newtonsoft.Json**: For JSON serialization/deserialization.
- **Dependency Injection**: For managing services and ensuring modularity.
- **Swagger**: For API documentation and testing.

---

## Prerequisites
1. A valid Companies House API key. Sign up [here](https://developer.companieshouse.gov.uk/developer/applications).
2. .NET 8.0 SDK installed. Download [here](https://dotnet.microsoft.com/download).
3. Visual Studio 2022+ or any preferred IDE.

---

## Installation and Setup

### Clone the Repository
```bash
git clone https://github.com/your-username/companies-house-api-integration.git
cd companies-house-api-integration
```

### Configure API Key
1. Navigate to the `appsettings.json` file.
2. Add your Companies House API key:
```json
{
  "CompaniesHouse": {
    "ApiKey": "your-api-key",
    "BaseUrl": "https://api.company-information.service.gov.uk/"
  }
}
```

### Restore Dependencies
```bash
dotnet restore
```

### Run the Application
```bash
dotnet run
```

The API will be accessible at `http://localhost:5000` (default port).

---

## API Endpoints

### 1. Search Companies
**Endpoint:** `GET /api/companies/search`

**Query Parameters:**
- `q`: Company name or number (required)

**Example Request:**
```bash
GET http://localhost:5000/api/companies/search?q=OpenAI
```

### 2. Company Details
**Endpoint:** `GET /api/companies/{companyNumber}`

**Path Parameter:**
- `companyNumber`: The unique registration number of the company (required)

**Example Request:**
```bash
GET http://localhost:5000/api/companies/12345678
```

### 3. Filing History
**Endpoint:** `GET /api/companies/{companyNumber}/filing-history`

**Path Parameter:**
- `companyNumber`: The unique registration number of the company (required)

**Example Request:**
```bash
GET http://localhost:5000/api/companies/12345678/filing-history
```

### 4. Officers Information
**Endpoint:** `GET /api/companies/{companyNumber}/officers`

**Path Parameter:**
- `companyNumber`: The unique registration number of the company (required)

**Example Request:**
```bash
GET http://localhost:5000/api/companies/12345678/officers
```

---

## Swagger Documentation
This project includes Swagger for easy API testing and documentation.
- **Access URL:** `http://localhost:5000/swagger`

---

## Error Handling
- **400 Bad Request:** Returned for invalid or missing parameters.
- **401 Unauthorized:** Returned for missing or invalid API keys.
- **404 Not Found:** Returned if no data is found for the specified parameters.
- **500 Internal Server Error:** Returned for unexpected errors.

---

## Contribution
We welcome contributions to enhance this integration! Please follow these steps:
1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature-name
   ```
3. Commit your changes:
   ```bash
   git commit -m "Added a new feature"
   ```
4. Push the branch:
   ```bash
   git push origin feature-name
   ```
5. Open a pull request.

---

## License
This project is licensed under the [MIT License](LICENSE).

---

## Contact
For questions or support, feel free to reach out:
- Email: [azizsagi@live.com]
- GitHub: [azizsagi](https://github.com/azizsagi)

