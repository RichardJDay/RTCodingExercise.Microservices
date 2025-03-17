import { Component } from '@angular/core';
import { PlatesListComponent } from "./plates-list/plates-list.component";
import { PlatesService } from '../../shared/services/plates.service';
import { Observable } from 'rxjs';
import { Plate } from '../../shared/models/plate';

@Component({
  selector: 'app-plates',
  imports: [PlatesListComponent],
  templateUrl: './plates.component.html',
  styleUrl: './plates.component.css'
})
export class PlatesComponent {

}
