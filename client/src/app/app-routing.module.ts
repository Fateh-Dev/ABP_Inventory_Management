import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { EnumerationComponent } from './enumeration/enumeration.component';

const routes: Routes = [
  {path: 'enums', component: EnumerationComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
