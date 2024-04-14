import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BaseService {

  private url = "http://localhost:5011/api/"

  private kolcsonzokSub = new Subject()
  private kolcsonzesekSub = new Subject()

  
  constructor(private http:HttpClient) { 
    this.loadKolcsonzok()
    this.loadKolcsonzesek()
  }

  private loadKolcsonzok(){
    this.http.get(this.url + "Kolcsonzo").subscribe({
      next: (res) => this.kolcsonzokSub.next(res),
      error: (err) => console.log(err)
    })
  }

  private loadKolcsonzesek(){
    this.http.get(this.url + "Kolcsonzes").subscribe({
      next: (res) => this.kolcsonzesekSub.next(res),
      error: (err) => console.log(err)
    })
  }

  getKolcsonzok(){
    return this.kolcsonzokSub
  
  }
  getKolcsonzesek(){
    return this.kolcsonzesekSub
  }

  deleteKolcsonzes(key:number){
    this.http.delete(this.url + "Kolcsonzes/" + key).forEach(
      () => this.loadKolcsonzesek()
    )
  }

  postKolcsonzes(body:any) {
    this.http.post(this.url + "Kolcsonzes/",body).forEach(
      () => this.loadKolcsonzesek()
    )
  }

  updateKolcsonzes(body:any){
    this.http.put(this.url+ "Kolcsonzes/" + body.id ,body).forEach(
      ()=>this.loadKolcsonzesek()
    )
  }
}
