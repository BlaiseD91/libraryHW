import { Component, OnInit } from '@angular/core';
import { BaseService } from 'src/app/services/base.service';

@Component({
  selector: 'app-kolcsonzok',
  templateUrl: './kolcsonzok.component.html',
  styleUrls: ['./kolcsonzok.component.css']
})
export class KolcsonzokComponent implements OnInit{

  kolcsonzok:any
  kivalasztottId?:number

  constructor(private base:BaseService) {
  }

  ngOnInit(){
    this.reachingKolcsonzok()
    console.log(this.kolcsonzok)
  }

  reachingKolcsonzok(){
    this.base.getKolcsonzok().subscribe(
      (res) => 
        {
          this.kolcsonzok = res
    })
  }

  setKivalasztott(kivalasztott:number){
    this.kivalasztottId = kivalasztott
  }
  getKivalasztott(){
    return this.kivalasztottId
  }

}
