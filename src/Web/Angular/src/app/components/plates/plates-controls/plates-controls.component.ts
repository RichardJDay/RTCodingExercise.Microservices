import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';
import { PlatesService } from '../../../shared/services/plates.service';
import { CreatePlateRequest } from '../../../shared/models/dtos/CreatePlateRequest';
@Component({
  selector: 'app-plates-controls',
  imports: [FormsModule, CommonModule],
  templateUrl: './plates-controls.component.html',
  styleUrl: './plates-controls.component.css'
})
export class PlatesControlsComponent {
  showCreateForm: boolean = false;
  constructor(private plateService: PlatesService) { }

  registration!: string;
  purchasePrice!: number;
  salePrice!: number;
  createPlate(){
    this.showCreateForm = !this.showCreateForm;
  }

  onSubmit(f: NgForm) {
    const plate: CreatePlateRequest = {
      registration: f.value.registration,
      purchasePrice: f.value.purchasePrice,
      salePrice: f.value.salePrice
    }
     this.plateService.createPlate(plate)
  }
}
