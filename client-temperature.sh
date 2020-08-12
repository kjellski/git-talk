#!/bin/bash

curl --silent https://localhost:5001/weatherforecast | jq '.[].temperatureFeeling'
