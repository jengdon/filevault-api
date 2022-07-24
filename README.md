<img align="right" width="200" height="200" src="https://github.com/jengdon/filevault-api/blob/main/img/filevault.svg?raw=true" alt="File vault" />

# File Vault API

![Build badge](https://github.com/jengdon/filevault-api/actions/workflows/build.yml/badge.svg?event=push)

This repository contains the code for File Vault's REST API, a service for storing your files with
end to end encryption.

## Build and Run

Using docker:

```
docker build -t filevault-api .
docker container run --rm -d -p 8081:80 --name filevault-api-run filevault-api
```
