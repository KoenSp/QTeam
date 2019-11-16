import { Component, OnInit } from '@angular/core';
import { faTimesCircle, faCheckCircle, faDotCircle, faCircle, faCheckSquare, faSquare } from '@fortawesome/free-solid-svg-icons'
import { QTeamService, IQTeamForm } from '../services/q-team.service'; 

@Component({
  selector: 'app-data-form',
  templateUrl: './data-form.component.html',
  styleUrls: ['./data-form.component.css']
})
export class DataFormComponent implements OnInit {

  inputInvalid = faTimesCircle; 
  inputValid = faCheckCircle; 
  faDhr = faDotCircle; 
  faMevr = faCircle; 
  checkBox = faCheckSquare; 

  qTeamForm : IQTeamForm;

  constructor(private _QTeamSVC : QTeamService) { }

  ngOnInit() {
    document.getElementById("radioMevr").style.color = "#eee"; 
    this.qTeamForm = {
      Geslacht : "Dhr", 
      Voornaam : "", 
      Naam : "", 
      Nummerplaat : "", 
      Email : "", 
      Straat : "", 
      Nummer : null, 
      Bus : "", 
      Stad : "", 
      Postcode : "", 
      Telefoon : "", 
      Nieuwsbrief : true
    }
  }

  radioDhr(){
    if(this.faDhr == faCircle){
      this.faDhr = faDotCircle; 
      this.faMevr = faCircle; 
      document.getElementById("radioDhr").style.color = "#e31d3c"; 
      document.getElementById("radioMevr").style.color = "#eee"; 
      this.qTeamForm.Geslacht = "Dhr"; 
    }
  }
  radioMevr(){
    if(this.faMevr == faCircle){
      this.faDhr = faCircle; 
      this.faMevr = faDotCircle; 
      document.getElementById("radioDhr").style.color = "#eee";
      document.getElementById("radioMevr").style.color = "#e31d3c";  
      this.qTeamForm.Geslacht = "Mevr"; 
    }
  }
  checkClick(){
    if(this.checkBox == faSquare){
      this.checkBox = faCheckSquare; 
      document.getElementById("checkBox").style.color = "#e31d3c"; 
      this.qTeamForm.Nieuwsbrief = true; 
    }
    else{
      this.checkBox = faSquare; 
      document.getElementById("checkBox").style.color = "#eee"; 
      this.qTeamForm.Nieuwsbrief = false; 
    }
  }
  onSubmit(){
    this._QTeamSVC.postQTeamForm(this.qTeamForm); 
  }
}
