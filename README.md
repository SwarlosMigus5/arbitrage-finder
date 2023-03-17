<h1 align="center"> Arbitrage Finder </h1> <br>

<p align="center">
  This microservice is responsible for finding the maximum amount of arbritage bets possible in a game. For it it will receive a list of odds from several bookmakers that combined with each other using a specific formula can become sure bets.
</p>

## Table of Contents

- [Domain](#introduction)
- [Features](#features)
- [Requirements](#requirements)
- [Quick Start](#quick-start)

## Domain

![Domain](https://github.com/skullizador/arbitrage-finder/blob/main/resources/domain.png)

## Features

* Calculate sure bets by game :heavy_check_mark:
* Get all sure bets by game :heavy_check_mark:
* Get sure bets by filter :heavy_check_mark:
* Get sure bets details :heavy_check_mark:

## Requirements
The application can be run locally or in a docker container, the requirements for each setup are listed below.

### Docker
* [Docker](https://www.docker.com/get-docker)

## Quick Start 
### Run Docker

First build the image:
```bash
$ docker build . -t arbitrage-finder:{version}
```

When ready, run it:
```bash
$ docker run -p {port:port} arbitrage-finder:{version}
```

Application will run by default on port `5000:80`