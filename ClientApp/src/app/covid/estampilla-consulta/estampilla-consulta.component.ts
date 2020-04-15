import { Component, OnInit } from '@angular/core';
import { Estampilla } from '../models/estampilla';
import { EstampillaService } from 'src/app/services/estampilla.service';

@Component({
  selector: 'app-estampilla-consulta',
  templateUrl: './estampilla-consulta.component.html',
  styleUrls: ['./estampilla-consulta.component.css']
})
export class EstampillaConsultaComponent implements OnInit {
  estampillas:Estampilla[];
constructor(private estampillaService: EstampillaService) { }
ngOnInit() {
this.estampillaService.get().subscribe(result => {
this.estampillas = result;
});
}
}
