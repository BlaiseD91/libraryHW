import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'fkfilter'
})
export class FkfilterPipe implements PipeTransform {

  transform(kolcsonzesek:any, key:number) {
    if (!kolcsonzesek) return null;
    if (!key) return kolcsonzesek;

    return kolcsonzesek.filter(
      (kolcsonzes:any)=>{return kolcsonzes.kolcsonzoId == key}
    )
  }
}
