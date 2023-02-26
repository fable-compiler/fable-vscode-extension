module Main

open Fable.Core.JsInterop
open Fable.Core.JS
(* The namespace 'Vscode' contains the VS Code extensibility API.
This line import everything under `Vscode` in the current scope. *)
open Fable.Import.VSCode.Vscode


// The code you place here will be executed every time your command is executed
let sayHello _ =
    (* Use the console to output diagnostic information (console.log) and errors (console.error)
    This line of code will only be executed once when your extension is activated *)
    console.log("Congratulations, your extension 'corkscrew' is now active!")

    // Display a message box to the user
    window.showInformationMessage("Hello from Fable!") |> ignore

    None

(* This method is called when your extension is activated
Your extension is activated the very first time the command is executed *)
let activate (context: ExtensionContext) =
    (* The command has been defined in the package.json file
    Now provide the implementation of the command with  registerCommand
    The commandId parameter must match the command field in package.json *)
    !!commands.registerCommand("fable.sayHello", sayHello)
    |> context.subscriptions.Add

// This method is called when your extension is deactivated
let deactivate _ = ()