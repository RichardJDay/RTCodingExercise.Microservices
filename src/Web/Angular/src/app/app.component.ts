import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { PlatesService } from './shared/services/plates.service';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Angular';


}
