import { Component, OnInit } from '@angular/core';
import { Estampilla } from '../models/estampilla';
import { EstampillaService } from 'src/app/services/estampilla.service';

@Component({
  selector: 'app-estampilla-registro',
  templateUrl: './estampilla-registro.component.html',
  styleUrls: ['./estampilla-registro.component.css']
})
export class EstampillaRegistroComponent implements OnInit {
  estampilla: Estampilla;
  constructor(private estampillaService: EstampillaService) { }
  ngOnInit() {
    this.estampilla = new Estampilla();
  }
  add() {
    this.estampillaService.post(this.estampilla).subscribe(e => {
      if (e != null) {
        alert('Estampilla creada!');
        this.estampilla = e;
      }
    });
  }
}
