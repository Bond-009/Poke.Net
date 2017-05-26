#!/bin/sh
cd test/Poke.Net.Tests
dotnet restore && dotnet test -c Release
