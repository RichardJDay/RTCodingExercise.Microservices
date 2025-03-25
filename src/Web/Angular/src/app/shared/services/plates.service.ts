import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Plate } from '../models/plate';
import { CreatePlateRequest } from '../models/dtos/CreatePlateRequest';
import { GetPlateRequest } from '../models/dtos/GetPlatesRequest';

@Injectable({
  providedIn: 'root'
})
export class PlatesService {

  constructor(private httpClient: HttpClient) { }
  private platesSource = new BehaviorSubject<Plate[]>([]);
  plates$ = this.platesSource.asObservable();

  getPlates(getPlateRequest: GetPlateRequest) {
    const params = new HttpParams().set('pageSize', getPlateRequest.pageSize).set('pageNumber', getPlateRequest.pageNumber);

    return this.httpClient.get<Plate[]>(`http://localhost:5101/api/plates`, { params: params }).subscribe((plates) => {
      this.platesSource.next(plates);
    });
  }

  createPlate(createPlateRequest: CreatePlateRequest) {
    return this.httpClient.post<Plate>('http://localhost:5101/api/plates', createPlateRequest).subscribe((plate) => {
      this.platesSource.next([...this.platesSource.value, plate]);
    });
  }
}
