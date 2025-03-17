import { Component, OnInit } from '@angular/core';
import { PlatesService } from '../../../shared/services/plates.service';
import { Plate } from '../../../shared/models/plate';
import { Observable } from 'rxjs';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-plates-list',
  imports: [CommonModule],
  templateUrl: './plates-list.component.html',
  styleUrl: './plates-list.component.css'
})
export class PlatesListComponent implements OnInit{
  plates$!: Observable<Plate[]>;
  constructor(private platesService: PlatesService) { }


  ngOnInit() {
    this.platesService.getPlates();
    this.plates$ = this.platesService.plates$;
  }
}
