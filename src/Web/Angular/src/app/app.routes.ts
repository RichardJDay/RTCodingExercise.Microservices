import { Routes } from '@angular/router';
import { PlatesComponent } from './components/plates/plates.component';

export const routes: Routes = [
    {path: '', redirectTo: 'plates', pathMatch: 'full'},
    {path: 'plates', component: PlatesComponent},
];
