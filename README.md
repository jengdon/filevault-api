# File Vault API

This repository contains the code for File Vault's REST API.

## Build and Run

Using docker:

```
docker build -t filevault-api .
docker container run --rm -d -p 8081:80 --name filevault-api-run filevault-api
```
