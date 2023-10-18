# htmx-pico-aspmvc
Boilerplate ASP MVC site with HTMX and Pico.css to play with POC ideas related to those libraries.

This project is based on work done here: https://surferjeff.medium.com/convert-an-asp-net-website-into-a-spa-using-htmx-1274ae0d8be8

This site uses Pico.css, HTMX, and ASP.Net MVC.

## Objectives

For this project I wanted to write minimal, clean, symantically idiomatic HTML and decorate it with HTMX tags to create a highly-
interactive and polished experience with very little code.  I chose an MVC framework (over, say, Razor Pages...) because it easily
supports returning partial HTML documents with simple routing.  Please note that the base _Layout shared view has been modified to return
only the body of the request if an HTMX request is detected.