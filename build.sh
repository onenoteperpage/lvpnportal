#!/bin/bash

docker build --rm --no-cache -t lvpnportal:dev .

docker run -d -p 80:80 --name lvpnportal lvpnportal:dev