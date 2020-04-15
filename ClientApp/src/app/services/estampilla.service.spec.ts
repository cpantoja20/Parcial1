import { TestBed } from '@angular/core/testing';

import { EstampillaService } from './estampilla.service';

describe('EstampillaService', () => {
  let service: EstampillaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(EstampillaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
