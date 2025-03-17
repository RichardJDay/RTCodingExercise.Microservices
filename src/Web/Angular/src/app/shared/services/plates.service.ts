import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { Plate } from '../models/plate';

@Injectable({
  providedIn: 'root'
})
export class PlatesService {

  constructor(private httpClient: HttpClient) { }
  private platesSource = new Subject<Plate[]>();
  plates$ = this.platesSource.asObservable();
  
  getPlates() {
    return this.httpClient.get<Plate[]>('http://localhost:5101/api/plates').subscribe((plates) => {
      this.platesSource.next(plates);
    });
  }
}
