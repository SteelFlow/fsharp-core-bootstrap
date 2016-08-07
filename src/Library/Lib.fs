module Library

open Newtonsoft.Json

let getJsonNetJson value =
    sprintf "I used to be %s but now I'm %s!" value (JsonConvert.SerializeObject(value))