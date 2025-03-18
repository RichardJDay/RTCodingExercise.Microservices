import { Component, OnInit } from '@angular/core';
import { PlatesService } from '../../../shared/services/plates.service';
import { Plate } from '../../../shared/models/plate';
import { Observable } from 'rxjs';
import { CommonModule } from '@angular/common';
import { GetPlateRequest } from '../../../shared/models/dtos/GetPlatesRequest';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-plates-list',
  imports: [CommonModule, FormsModule],
  templateUrl: './plates-list.component.html',
  styleUrl: './plates-list.component.css'
})
export class PlatesListComponent implements OnInit {

  plates$!: Observable<Plate[]>;
  constructor(private platesService: PlatesService) { }

  getPlateRquest: GetPlateRequest = {
    pageSize: 20,
    pageNumber: 1,
  }

  ngOnInit() {
    this.platesService.getPlates(this.getPlateRquest);
    this.plates$ = this.platesService.plates$;
  }

  nextPage() {
    this.getPlateRquest.pageNumber++;
    this.platesService.getPlates(this.getPlateRquest);
  }

  prevPage() {
    if (this.getPlateRquest.pageNumber > 1)
      this.getPlateRquest.pageNumber--;
    this.platesService.getPlates(this.getPlateRquest);
  }
}
