$(function () {

    var drawPerspective = function (a1, b1, s1, a2, b2, s2, canvasId, scale, normal, label) {
        var canvas = document.getElementById(canvasId);
        scale = scale || 10;
        var adjust = scale / normal;
        var adjustCenter = function (cord, size) {
            return cord < 0 ? cord + (size / 2) : cord - (size / 2);
        }
        a1 = a1 * adjust;
        a2 = a2 * adjust;
        b1 = b1 * adjust;
        b2 = b2 * adjust;
        s1 = s1 * adjust;
        s2 = s2 * adjust;

        if (canvas.getContext) {
            var ctx = canvas.getContext('2d');
            ctx.lineWidth = 1;
            ctx.strokeStyle = "blue";
            ctx.strokeRect(adjustCenter(a1, s1), adjustCenter(b1, s1), s1, s1);
            ctx.strokeStyle = "red";
            ctx.strokeRect(adjustCenter(a2, s2), adjustCenter(b2, s2), s2, s2);
            ctx.strokeStyle = "green";
            ctx.fillText(label, 2, 10);
        }
    }
    var x1 = $('#cubeA #txtXCoord').val();
    var y1 = $('#cubeA #txtYCoord').val();
    var z1 = $('#cubeA #txtZCoord').val();
    var s1 = $('#cubeA #txtSize').val();
    var x2 = $('#cubeB #txtXCoord').val();
    var y2 = $('#cubeB #txtYCoord').val();
    var z2 = $('#cubeB #txtZCoord').val();
    var s2 = $('#cubeB #txtSize').val();

    var max = Math.max(Math.max(Math.abs(x1), Math.abs(y1), Math.abs(z1)) + s1 / 2, Math.max(Math.abs(x2), Math.abs(y2), Math.abs(z2)) + s2 / 2);
    var canvasHeight = $('#canvasCubesXY').height();
    var normal = (canvasHeight < max ? (max / canvasHeight) : 1);

    drawPerspective(x1, y1, s1, x2, y2, s2, 'canvasCubesXY', 10, normal, 'X Y');
    drawPerspective(x1, z1, s1, x2, z2, s2, 'canvasCubesXZ', 10, normal, 'X Z');
    drawPerspective(y1, z1, s1, y2, z2, s2, 'canvasCubesYZ', 10, normal, 'Y Z');
});