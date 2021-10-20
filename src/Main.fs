module Main

open Fable.Core.JsInterop
open Fable.Import.VSCode.Vscode

let sayHello _ =
    window.showInformationMessage("Hello from Fable!") |> ignore
    None

let activate (context: ExtensionContext) =
    !!commands.registerCommand("fable.sayHello", sayHello)
    |> context.subscriptions.Add