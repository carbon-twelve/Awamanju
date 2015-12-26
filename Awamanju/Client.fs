namespace Awamanju

open WebSharper
open WebSharper.UI.Next
open WebSharper.UI.Next.Html
open WebSharper.UI.Next.Client

[<JavaScript>]
module Client =

    let Main () =
        let rvContent = Var.Create ""
        let vUpperContent =
            rvContent.View
            |> View.Map (fun t -> t.ToUpper())
        div [
            Doc.Input [] rvContent
            label [textView vUpperContent]
        ]

         