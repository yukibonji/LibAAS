﻿[<AutoOpen>]
module LibASS.Contracts.Events
open System

type EventData = 
    | ItemRegistered of item:Item * Quantity:Quantity

type Events = AggregateId * EventData list
