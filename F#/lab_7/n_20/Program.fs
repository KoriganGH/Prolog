﻿open System

let count_cg_gc str = 
    let lenght = String.length(str)
    let i_str = Seq.indexed str
    let str1 = Seq.filter(fun x -> fst x <> lenght-1) i_str
    let str2 = Seq.filter(fun x -> fst x <> 0) i_str
    Seq.fold2 (fun s x y -> if (((snd x = 'А' || snd x ='а' || snd x ='о' || snd x ='О' || snd x ='Э' || snd x ='э' || snd x ='Е' || snd x ='е' || snd x ='И' || snd x ='и' || snd x ='Ы' || snd x ='ы' || snd x ='У' || snd x ='у' || snd x ='Ё' || snd x ='ё' || snd x ='Ю' || snd x ='ю' || snd x ='Я' || snd x ='я')
&& (snd y = 'б' || snd y ='Б' || snd y ='в' || snd y ='В' || snd y ='г' || snd y ='Г' || snd y ='д' || snd y ='Д' || snd y ='ж' || snd y ='Ж' || snd y ='з' || snd y ='З' || snd y ='й' || snd y ='Й' || snd y ='к' || snd y ='К' || snd y ='л' || snd y ='Л' || snd y ='м' || snd y ='М' ||snd y ='н' || snd y ='Н' || 
snd y ='п' || snd y ='П' || snd y ='р' || snd y ='Р' || snd y ='с' || snd y ='С' || snd y ='т' || snd y ='Т' || snd y ='ф' || snd y ='Ф' || snd y ='х' || snd y ='Х' || snd y ='ц' || snd y ='Ц' || snd y ='ч' || snd y ='Ч' || snd y ='ш' || snd y ='Ш' || snd y ='щ' || snd y ='Щ')) || 
((snd y = 'А' || snd y ='а' || snd y ='о' || snd y ='О' || snd y ='Э' || snd y ='э' || snd y ='Е' || snd y ='е' || snd y ='И' || snd y ='и' || snd y ='Ы' || snd y ='ы' || snd y ='У' || snd y ='у' || snd y ='Ё' || snd y ='ё' || snd y ='Ю' || snd y ='ю' || snd y ='Я' || snd y ='я')
&& (snd x = 'б' || snd x ='Б' || snd x ='в' || snd x ='В' || snd x ='г' || snd x ='Г' || snd x ='д' || snd x ='Д' || snd x ='ж' || snd x ='Ж' || snd x ='з' || snd x ='З' || snd x ='й' || snd x ='Й' || snd x ='к' || snd x ='К' || snd x ='л' || snd x ='Л' || snd x ='м' || snd x ='М' ||snd x ='н' || snd x ='Н' || 
snd x ='п' || snd x ='П' || snd x ='р' || snd x ='Р' || snd x ='с' || snd x ='С' || snd x ='т' || snd x ='Т' || snd x ='ф' || snd x ='Ф' || snd x ='х' || snd x ='Х' || snd x ='ц' || snd x ='Ц' || snd x ='ч' || snd x ='Ч' || snd x ='ш' || snd x ='Ш' || snd x ='щ' || snd x ='Щ'))) then s+1 else s) 0 str1 str2

let print str = 
    Array.map(fun x -> printf "%s " x) str

let task (str:string) =
    let strs = str.Split(' ')
    Array.sortBy(fun x -> count_cg_gc x) strs

[<EntryPoint>]
let main argv = 
   let str = Console.ReadLine();
   str |> task |> print |> ignore
   0