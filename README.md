# DocumentIntelligenceClient

DocumentIntelligenceClient is a library designed to interact with Azure Document Intelligence (formerly Azure Form Recognizer). It provides functionalities to extract structured data from documents, enabling automation and efficient data processing for various scenarios.

## Table of Contents

1. [Introduction](#introduction)
2. [Features](#features)
3. [Tech Stack](#tech-stack)
4. [Usage](#usage)
5. [Configuration](#configuration)

## Introduction

DocumentIntelligenceClient provides a simple and efficient way to interact with Azure Document Intelligence APIs. It supports extracting key-value pairs, tables, and other structured data from documents, making it ideal for automating document processing workflows in various domains.

## Features

- **Analyze Document:** Extract structured data from documents such as invoices, receipts, forms, and more.
- **Extract Key-Value Pairs:** Identify and retrieve key-value pairs from documents.
- **Extract Tables:** Extract tabular data from documents with complex structures.
- **Custom Models:** Leverage trained models to process proprietary document formats.
- **Multi-Format Support:** Handle documents in various formats such as PDF, JPEG, PNG, and TIFF.

## Tech Stack

- **Backend:** .NET 8
- **Service:** Azure Document Intelligence
- **Dependency Injection:** Used for service registrations and configurations

## Usage

1. **Register the DocumentIntelligenceClient:** Use the `RegisterDocumentIntelligenceClient` extension method to register the client in the dependency injection container.
2. **Configure the options:** Set up `DocumentIntelligenceClientOptions` with the necessary configuration, including the endpoint URI, API key, and model ID.
3. **Perform Operations:** Use methods such as `AnalyzeDocumentAsync` to extract structured data from supported document types.

## Configuration

### DocumentIntelligenceClientOptions

- **EndpointUri:** The URI of the Azure Document Intelligence endpoint.
- **ApiKey:** The API key for authenticating with Azure Document Intelligence.

```csharp
public class DocumentIntelligenceClientOptions
{
    public string EndpointUri { get; set; }
    public string ApiKey { get; set; }
}
```