import { Component } from '@angular/core';
import { PlatesListComponent } from "./plates-list/plates-list.component";
import { PlatesService } from '../../shared/services/plates.service';
import { Observable } from 'rxjs';
import { Plate } from '../../shared/models/plate';
import { PlatesControlsComponent } from "./plates-controls/plates-controls.component";

@Component({
  selector: 'app-plates',
  imports: [PlatesListComponent, PlatesControlsComponent],
  templateUrl: './plates.component.html',
  styleUrl: './plates.component.css'
})
export class PlatesComponent {

}
