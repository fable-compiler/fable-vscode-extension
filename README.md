# Fable VS Code Extension Sample

Example that can be used as a base to write a VS Code extension with Fable.

This example repository provides a great starting point for writing VS Code extensions using F#/Fable.

## Requirements

- dotnet SDK 7.0.201
- Node.js v19.5.0
- NPM 9.3.1

## Setup

Run `npm install` to install dependencies.

## Usage

To test the extension while actively making changes, run `npm start` and then in VS Code click `F5` (Start debugging) or `Ctrl+F5` (Run without debugging). 

To run a single build, run `npm run build`, or press `Shift+Ctrl+B` and select `npm: build`. Once completed, press `F5` or `Ctrl+F5` to test the extension.

Open command palette and search for 'Say Hello from Fable!'. 
You should see a notification appear. 
Also check the console.log.

## Publishing

To publish, edit `package.json` with your publishing data and then run: `npm run pack` to create the package.

## Next steps

- [Your First Extension | Visual Studio Code Extension API](https://code.visualstudio.com/api/get-started/your-first-extension)
- [Creating VS Code plugins with F# and Fable | Blog post](http://kcieslak.io/Creating-VS-Code-plugins-with-F-and-Fable)
- [Announcing Fable 4 Theta Release | Blog post](https://fable.io/blog/2022/2022-09-28-fable-4-theta.html)