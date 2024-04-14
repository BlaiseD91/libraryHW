import { Component, Input, OnInit } from '@angular/core';
import { BaseService } from 'src/app/services/base.service';

@Component({
  selector: 'app-kolcsonzesek',
  templateUrl: './kolcsonzesek.component.html',
  styleUrls: ['./kolcsonzesek.component.css']
})
export class KolcsonzesekComponent implements OnInit {
  @Input() data?:any;

  kolcsonzesek:any

  newKolcsonzes = {
    kolcsonzoId: this.data,
    iro: "",
    mufaj: "",
    cim: ""
  }

  constructor(private base:BaseService) {
  }

  ngOnInit(): void {
    this.base.getKolcsonzesek().subscribe(
      (res) => this.kolcsonzesek = res
    )
  }
  deleteKolcsonzes(key:number){
    console.log(key)
    this.base.deleteKolcsonzes(key)
  }

  modifyKolcsonzes(body:any){
    this.base.updateKolcsonzes(body)
  }

  upload(){
    console.log(this.newKolcsonzes.kolcsonzoId)
    this.base.postKolcsonzes(this.newKolcsonzes)
    this.clrData()
  }

  clrData(){
    this.newKolcsonzes = {
      kolcsonzoId: this.data,
      iro: "",
      mufaj: "",
      cim: ""
    }
  }

  


}
