#!/bin/bash

docker stop pp
docker build --rm --no-cache -t lunavportal .
docker run --rm -d -p 8081:80 --name pp lunavportal
