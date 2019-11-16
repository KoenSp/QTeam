import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'; 

@Injectable({
  providedIn: 'root'
})
export class QTeamService {
  url: string = "https://localhost:44391/api/qteamform"; 

  constructor(private http : HttpClient) { }

  postQTeamForm(form : IQTeamForm){
    this.http.post(this.url, form).subscribe(x => console.log(x)); 
  }
}
export interface IQTeamForm{
  Geslacht : string, 
  Voornaam : string, 
  Naam : string, 
  Nummerplaat : string, 
  Email : string, 
  Straat : string, 
  Nummer : number, 
  Bus : string, 
  Stad : string, 
  Postcode : string, 
  Telefoon : string, 
  Nieuwsbrief : boolean
}
