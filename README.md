# Debugging on Production with .NET Talk Demos
Code for my talk on Debugging on Production with .NET

Slides: https://docs.google.com/presentation/d/1kTFI4gaVh4vggnL-amFuD-EUlJMOUEy049GCwvELSp4/edit?usp=sharing

## Overview
This demo project has been setup with intentionally  errors for testing out Application Insight integration features when hosting with Azure Web Apps.

### Details
Contains two projects both with the same basic application. 
One written in .NET Core 3.1 and one written in .NET Framework 4.6.2.

Application lets users register their intrest for the service.
If they are < 13 years old the site should show an error message.
Registrations are stored in an SQL database.
